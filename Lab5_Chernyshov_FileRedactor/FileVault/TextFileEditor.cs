using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileVault
{
    /// <summary>
    /// Редактор текстовых файлов
    /// </summary>
    public class TextFileEditor : IFileEditor
    {
        public void Open(string filename)
        {
            Console.WriteLine("Файл открыт в текстовом редакторе");
            ///Симулируем редактирование файла. Предполагается использование async функций
            Task.Delay(3000).Wait();
            Console.WriteLine("Текстовый редактор закрыт");
        }
    }
}
