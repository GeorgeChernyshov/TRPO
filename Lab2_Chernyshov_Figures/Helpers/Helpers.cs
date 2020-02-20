using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Helpers.HelpersExceptions;

namespace Helpers
{
    /// <summary>
    /// Класс, содержащий вспомогательные функции
    /// </summary>
    public static class Helpers
    {
        /// <summary>
        /// Функция, выполняющая приведение строки к целому числу.
        /// Перед приведением производится проверка строки на корректность
        /// </summary>
        /// <param name="input">Входная строка</param>
        /// <returns>Целое число</returns>
        public static int TryParseInt(string input)
        {
            Trace.WriteLine("Вызвана функция TryParseInt");

            for (int i = 0; i < input.Length; i++)
                if (!(Char.IsDigit(input[i]) || (input[i] == '-' && i == 0)))
                    throw new NotANumberException();

            if (input[0] == '0' && input.Length > 1)
                throw new NotANumberException();

            int answer = 0;
            if (!Int32.TryParse(input, out answer))
                throw new NotANumberException();

            return answer;
        }

        /// <summary>
        /// Функция, выполняющая приведение строки к числу формата Double
        /// Перед приведением производится проверка строки на корректность
        /// </summary>
        /// <param name="input">Входная строка</param>
        /// <returns>Полученное число формата Double</returns>
        public static double TryParseDouble(string input)
        {
            Trace.WriteLine("Вызвана функция TryParseDouble");

            double answer = 0;
            if (!Double.TryParse(input, out answer))
                throw new NotANumberException();

            return answer;
        }
    }
}
