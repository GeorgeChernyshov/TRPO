using System;
using System.Text;
using System.Net.Sockets;
using System.IO;
using System.Threading.Tasks;

namespace SomeProject.Library.Client
{
    public class Client
    {
        /// <summary>
        /// Порт
        /// </summary>
        private const int port = 4040;

        /// <summary>
        /// Клиент TCP
        /// </summary>
        public TcpClient tcpClient;

        /// <summary>
        /// Событие, вызываемое при получении сообщения
        /// </summary>
        public event Action<string> OnMessageReceived;

        /// <summary>
        /// Клиент
        /// </summary>
        public Client()
        {
            tcpClient = new TcpClient();
        }

        /// <summary>
        /// Получение сообщение от сервера
        /// </summary>
        /// <returns>Результат операции</returns>
        public OperationResult ReceiveMessageFromServer()
        {
            try
            {
                if (!tcpClient.Connected)
                    tcpClient = new TcpClient("127.0.0.1", port);
                StringBuilder recievedMessage = new StringBuilder();
                byte[] data = new byte[256];
                NetworkStream stream = tcpClient.GetStream();

                do
                {
                    int bytes = stream.Read(data, 0, data.Length);
                    recievedMessage.Append(Encoding.UTF8.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                OnMessageReceived.Invoke(recievedMessage.ToString());
                stream.Close();
                tcpClient.Close();
                return new OperationResult(Result.OK, recievedMessage.ToString());
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.ToString());
            }
        }

        /// <summary>
        /// Отправка сообщения на сервер
        /// </summary>
        /// <param name="message">Сообщение</param>
        /// <returns>Результат операции</returns>
        public OperationResult SendMessageToServer(string message)
        {
            try
            {
                if(!tcpClient.Connected)
                    tcpClient = new TcpClient("127.0.0.1", port);
                NetworkStream stream = tcpClient.GetStream();

                var dataType = Encoding.UTF8.GetBytes("DataType: Message;");
                var data = System.Text.Encoding.UTF8.GetBytes(message);
                stream.Write(dataType, 0, dataType.Length);
                stream.Write(data, 0, data.Length);

                ReceiveMessageFromServer();
                stream.Close();
                tcpClient.Close();
                return new OperationResult(Result.OK, "") ;
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }

        /// <summary>
        /// Отправка файла на сервер
        /// </summary>
        /// <param name="filename">Имя файла</param>
        /// <returns>Результат операции</returns>
        public OperationResult SendFileToServer(string filename)
        {
            try
            {
                if(!tcpClient.Connected)
                    tcpClient = new TcpClient("127.0.0.1", port);
                NetworkStream stream = tcpClient.GetStream();

                var dataType = Encoding.UTF8.GetBytes("DataType: File;");
                var extension = Encoding.UTF8.GetBytes("Extension: " + Path.GetExtension(filename) + ";");
                var data = File.ReadAllBytes(filename);
                stream.Write(dataType, 0, dataType.Length);
                stream.Write(extension, 0, extension.Length);
                stream.Write(data, 0, data.Length);

                ReceiveMessageFromServer();
                stream.Close();
                tcpClient.Close();
                return new OperationResult(Result.OK, "");
            }
            catch (Exception e)
            {
                return new OperationResult(Result.Fail, e.Message);
            }
        }
    }
}
