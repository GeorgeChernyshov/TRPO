using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWork
{
    /// <summary>
    /// Исключение - отсутствие обработчика заданного типа БД
    /// </summary>
    public class InvalidDatabaseTypeException : Exception { }

    /// <summary>
    /// Исключение - отсутствие заданной команды
    /// </summary>
    public class InvalidCommandException : Exception { }
}
