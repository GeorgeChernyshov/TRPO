using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileVault
{
    /// <summary>
    /// Интерфейс для работы с файловыми редакторами
    /// </summary>
    public interface IFileEditor
    {
        /// <summary>
        /// Открытие файла в редакторе
        /// </summary>
        /// <param name="filename">Наименование файла</param>
        void Open(string filename);
    }
}
