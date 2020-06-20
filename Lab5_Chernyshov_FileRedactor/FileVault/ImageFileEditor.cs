using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileVault
{
    /// <summary>
    /// Редактор изображений
    /// </summary>
    public class ImageFileEditor : IFileEditor
    {
        public void Open(string filename)
        {
            Console.WriteLine("Файл открыт в редакторе изображений");
            ///Симулируем редактирование файла. Предполагается использование async функций
            Task.Delay(3000).Wait();
            Console.WriteLine("Редактор изображений закрыт");
        }
    }
}
