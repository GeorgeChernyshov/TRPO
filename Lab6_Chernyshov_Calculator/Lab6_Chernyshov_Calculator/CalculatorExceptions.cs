using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Переполнение числа
    /// </summary>
    public class NumberOverflowException : Exception { }
    /// <summary>
    /// Параметр не является цифрой
    /// </summary>
    public class NotADigitException : Exception { }
    /// <summary>
    /// Результат вычислений не является числом
    /// </summary>
    public class NotANumberException : Exception { }
}
