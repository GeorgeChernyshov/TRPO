﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileVault
{
    /// <summary>
    /// Редактор PDF-документов
    /// </summary>
    public class PdfFileEditor : IFileEditor
    {
        public void Open(string filename)
        {
            Console.WriteLine("Файл открыт в редакторе PDF");
            ///Симулируем редактирование файла. Предполагается использование async функций
            Task.Delay(3000).Wait();
            Console.WriteLine("Редактор PDF закрыт");
        }
    }
}
