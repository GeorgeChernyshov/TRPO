using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileVault
{
    /// <summary>
    /// Класс, отвечающий за работу с файловым хранилищем
    /// </summary>
    public class FileVaultConnection
    {
        /// <summary>
        /// Открытие соединения с хранилищем
        /// </summary>
        public void Connect() => Console.WriteLine("Подключен к хранилищу");

        /// <summary>
        /// Закрытие соединения с хранилищем
        /// </summary>
        public void Disconnect() => Console.WriteLine("Отключен от хранилища");

        /// <summary>
        /// Загрузка файла из хранилища
        /// </summary>
        /// <param name="filename">Наименование файла</param>
        public void DownloadFile(string filename) 
        {
            if (!this.Contains(filename))
                throw new NoFileInTheVaultException();

            Console.WriteLine("Файл загружен из хранилища");
        }

        /// <summary>
        /// Загрузка файла для редактирования
        /// </summary>
        /// <param name="filename">Наименование файла</param>
        public void DownloadToEdit(string filename)
        {
            DownloadFile(filename);
            Lock(filename);
        }

        /// <summary>
        /// Загрузка файла в хранилище
        /// </summary>
        /// <param name="filename">Наименование файла</param>
        public void UploadFile(string filename) 
        {
            if (!File.Exists(filename))
                throw new FileNotFoundException();

            Console.WriteLine("Файл выгружен в хранилище");
        }

        /// <summary>
        /// Загрузка отредактированного файла на сервер
        /// </summary>
        /// <param name="filename">Наименование файла</param>
        public void UploadEditedFile(string filename)
        {
            UploadFile(filename);
            Unlock(filename);
        }

        /// <summary>
        /// Проверка наличия файла в хранилище
        /// </summary>
        /// <param name="filename">Наименование файла</param>
        /// <returns></returns>
        public bool Contains(string filename)
        {
            return true;
        }

        /// <summary>
        /// Запрет редактирования файла другими пользователями
        /// </summary>
        /// <param name="filename">Наименование файла</param>
        private void Lock(string filename)
        {
            if (!this.Contains(filename))
                throw new NoFileInTheVaultException();

            Console.WriteLine("Файл заблокирован для изменения другими пользователями");
        }

        /// <summary>
        /// Снятие блокировки файла
        /// </summary>
        /// <param name="filename">Наименование файла</param>
        private void Unlock(string filename)
        {
            if (!this.Contains(filename))
                throw new NoFileInTheVaultException();

            Console.WriteLine("Файл разблокирован для изменения другими пользователями");
        }
    }
}
