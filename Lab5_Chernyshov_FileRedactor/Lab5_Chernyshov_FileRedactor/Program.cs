using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileVault;

namespace Lab5_Chernyshov_FileRedactor
{
    /// <summary>
    /// В системе используется много различных сущностей: пользователь, хранилище, различные файловые редакторы. 
    /// Каждая из описанных выше функций требует использования сразу нескольких из них. 
    /// Таким образом, возникает несколько проблем:
    /// 1.	Код неустойчив к изменениям подсистем.
    /// 2.	Код тяжело масштабировать.
    /// 3.	Общая запутанность кода.
    /// 
    /// Для решения проблемы будет использован шаблон "Фасад"
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var worker = new FileVaultWorker();
                worker.EditFile("File.pdf");
            }
            catch(NoFileInTheVaultException)
            {
                Console.WriteLine("Файл отсутствует в хранилище");
            }
            catch(FileNotFoundException)
            {
                Console.WriteLine("Файл не найден");
            }
        }
    }
}
