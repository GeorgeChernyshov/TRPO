using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace SomeProject.Library.Server
{
    public class Server
    {
        /// <summary>
        /// TCP слушатель
        /// </summary>
        private TcpListener serverListener;

        /// <summary>
        /// Обработчики данных разных типов
        /// </summary>
        private Dictionary<string, Func<NetworkStream, Task<OperationResult>>> datatypeHandlers;

        /// <summary>
        /// Корневая папка
        /// </summary>
        private const string rootDirectory = "../../Saved Files";

        /// <summary>
        /// Количество файлов
        /// </summary>
        private int fileCount;

        /// <summary>
        /// Текущее количество соединений
        /// </summary>
        private int curConnections = 0;

        /// <summary>
        /// Максимальное количество соединений
        /// </summary>
        private int maxConnections = 4;

        /// <summary>
        /// Сервер
        /// </summary>
        public Server()
        {
            serverListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 4040);
            var info = Directory.CreateDirectory(rootDirectory);
            fileCount = info.GetDirectories()
                .Select(d => d.GetFiles().Length).Sum();
            datatypeHandlers = new Dictionary<string, Func<NetworkStream, Task<OperationResult>>>
            {
                { "Message", ReceiveMessage },
                { "File", ReceiveFile }
            };
        }

        /// <summary>
        /// Отключение прослушивания
        /// </summary>
        /// <returns>Результат операции</returns>
        public bool TurnOffListener()
        {
            try
            {
                if (serverListener != null)
                    serverListener.Stop();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot turn off listener: " + e.Message);
                return false;
            }
        }

        /// <summary>
        /// Включение прослушивания
        /// </summary>
        /// <returns>Результат операции</returns>
        public async Task TurnOnListener()
        {
            try
            {
                if (serverListener != null)
                    serverListener.Start();
                while (true)
                {
                    Console.WriteLine("Waiting for connections...");
                    OperationResult result = new OperationResult(Result.Fail, "");
                    var client = serverListener.AcceptTcpClient();
                    ReceiveDataFromClient(client);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Cannot turn on listener: " + e.Message);
            }
        }

        /// <summary>
        /// Получениу данных от клиента
        /// </summary>
        /// <param name="client">Клиент</param>
        public async void ReceiveDataFromClient(TcpClient client)
        {
            try
            {
                if (curConnections >= maxConnections)
                    throw new Exception("Connection limit reached.");
                Interlocked.Increment(ref curConnections);
                NetworkStream stream = client.GetStream();
                List<byte> header = new List<byte>();
                byte b = 0;
                while(b != Encoding.UTF8.GetBytes(";").First())
                {
                    b = (byte)stream.ReadByte();
                    header.Add(b);
                }

                var headerString = Encoding.UTF8.GetString(header.ToArray());
                string datatype = headerString
                    .Replace("DataType: ", "")
                    .Replace(";", "");

                var result = await datatypeHandlers[datatype](stream);
                SendMessageToClient(client, result.Message);

                stream.Close();
                client.Close();
                Interlocked.Decrement(ref curConnections);
                Console.WriteLine(result.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }

        /// <summary>
        /// Асинхронное получение текстового сообщения от сервера
        /// </summary>
        /// <param name="stream">Сетевой поток</param>
        /// <returns>Результат операции</returns>
        public async Task<OperationResult> ReceiveMessage(NetworkStream stream)
        {
            try
            {
                StringBuilder receivedMessage = new StringBuilder();
                byte[] data = new byte[256];
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    receivedMessage.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                return new OperationResult(Result.OK, "Received message from client: " + receivedMessage.ToString());
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }

        /// <summary>
        /// Асинхронное получение файла
        /// </summary>
        /// <param name="stream">Сетевой поток</param>
        /// <returns>Результат операции</returns>
        public async Task<OperationResult> ReceiveFile(NetworkStream stream)
        {
            var directory = Directory.CreateDirectory(rootDirectory + "/" + DateTime.Now.ToString("yyyy-MM-dd"));
            int fileNum = Interlocked.Increment(ref fileCount);
            string extension = GetFileExtension(stream);
            string fileName = String.Format("File{0}{1}", fileNum, extension);
            using (var fileStream = new FileStream(directory.FullName + "/" + fileName, FileMode.OpenOrCreate))
            {
                byte[] data = new byte[256];
                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    fileStream.Write(data, 0, bytes);
                }
                while (stream.DataAvailable);
            }

            return new OperationResult(Result.OK, fileName + " successfully uploaded!");
        }

        /// <summary>
        /// Отправка сообщения клиенту
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <returns>Результат операции</returns>
        public OperationResult SendMessageToClient(string message)
            => SendMessageToClient(serverListener.AcceptTcpClient(), message);

        /// <summary>
        /// Отправка сообщения клиенту
        /// </summary>
        /// <param name="client">Клиент</param>
        /// <param name="message">Сообщение</param>
        /// <returns>Результат операции</returns>
        public OperationResult SendMessageToClient(TcpClient client, string message)
        {
            try
            {
                NetworkStream stream = client.GetStream();

                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                stream.Close();
                client.Close();
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }

            return new OperationResult(Result.OK, "");
        }

        /// <summary>
        /// Получение расширения передаваемого файла
        /// </summary>
        /// <param name="stream">Сетевой поток</param>
        /// <returns>Расширение</returns>
        private string GetFileExtension(NetworkStream stream)
        {
            List<byte> header = new List<byte>();
            byte b = 0;
            while (b != Encoding.UTF8.GetBytes(";").First())
            {
                b = (byte)stream.ReadByte();
                header.Add(b);
            }

            var headerString = Encoding.UTF8.GetString(header.ToArray());
            return headerString.Replace("Extension: ", "").Replace(";", "");
        }
    }
}