using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    /// <summary>
    /// Класс, содержащий исключения, выбрасываемые вспомогательными функциями
    /// </summary>
    public static class FigureExceptions
    {
        /// <summary>
        /// Исключение, бросаемое в случае, когда название фигуры некорректно
        /// </summary>
        public class IllegalFigureException : Exception
        {
            /// <summary>
            /// Сообщение об ошибке
            /// </summary>
            const string message = "Неправильное название фигуры";

            /// <summary>
            /// Конструктор класса
            /// </summary>
            public IllegalFigureException() : base(message) { }
        }
    }
}
