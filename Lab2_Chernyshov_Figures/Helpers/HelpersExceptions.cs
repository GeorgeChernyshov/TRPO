using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers
{
    /// <summary>
    /// Класс, содержащий исключения, выбрасываемые вспомогательными функциями
    /// </summary>
    public static class HelpersExceptions
    {
        /// <summary>
        /// Исключение, бросаемое в случае, когда параметр не является числом
        /// </summary>
        public class NotANumberException : Exception
        {
            /// <summary>
            /// Сообщение об ошибке
            /// </summary>
            const string message = "Введённое значение не является корректным числом.";

            /// <summary>
            /// Конструктор класса
            /// </summary>
            public NotANumberException() : base(message) { }
        }

        /// <summary>
        /// Исключение, бросаемое в случае, когда параметр является отрицательным числом
        /// </summary>
        public class NegativeNumberException : Exception
        {
            /// <summary>
            /// Сообщение об ошибке
            /// </summary>
            const string message = "Введено отрицательное число.";

            /// <summary>
            /// Конструктор класса
            /// </summary>
            public NegativeNumberException() : base(message) { }
        }
    }
}
