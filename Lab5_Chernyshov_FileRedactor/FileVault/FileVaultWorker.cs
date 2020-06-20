using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileVault
{
    /// <summary>
    /// Класс, предоставляющий фасад для объединения подсистем
    /// </summary>
    public class FileVaultWorker
    {
        /// <summary>
        /// Класс для работы с хранилищем
        /// </summary>
        private FileVaultConnection vaultConnection;
        
        /// <summary>
        /// Редакторы различных типов файлов
        /// </summary>
        private TextFileEditor textFileEditor;
        private PdfFileEditor pdfFileEditor;
        private ImageFileEditor imageFileEditor;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public FileVaultWorker()
        {
            vaultConnection = new FileVaultConnection();
            textFileEditor = new TextFileEditor();
            pdfFileEditor = new PdfFileEditor();
            imageFileEditor = new ImageFileEditor();
        }

        /// <summary>
        /// Создание на клиенте локальной копии файла из хранилища
        /// </summary>
        /// <param name="filename">Название файла</param>
        public void DownloadFile(string filename)
        {
            vaultConnection.Connect();
            vaultConnection.DownloadFile(filename);
            vaultConnection.Disconnect();
        }

        /// <summary>
        /// Загрузка нового файла в хранилище
        /// </summary>
        /// <param name="filename">Название файла</param>
        public void UploadFile(string filename)
        {
            vaultConnection.Connect();
            vaultConnection.UploadFile(filename);
            vaultConnection.Disconnect();
        }

        /// <summary>
        /// Редактирование файла из хранилища
        /// </summary>
        /// <param name="filename">Название файла</param>
        public void EditFile(string filename)
        {
            IFileEditor editor = null;
            vaultConnection.Connect();
            vaultConnection.DownloadToEdit(filename);
            switch(Path.GetExtension(filename))
            {
                case "pdf":
                    editor = pdfFileEditor;
                    break;
                case "bmp":
                    editor = imageFileEditor;
                    break;
                default:
                    editor = textFileEditor;
                    break;
            }

            editor.Open(filename);
            vaultConnection.UploadEditedFile(filename);
            vaultConnection.Disconnect();
        }
    }
}
