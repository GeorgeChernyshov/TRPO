using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    /// <summary>
    /// Число для раюоты с калькулятором.
    /// Является числом с плавающей точкой с максимальной длиной 16 символов
    /// </summary>
    public class CalculatorNumber
    {
        /// <summary>
        /// Строка, хранящая значение числа
        /// </summary>
        private string _numStr;

        public CalculatorNumber() => _numStr = "";
        public CalculatorNumber(double num) => SetValue(num);
        public CalculatorNumber(CalculatorNumber num) => SetValue(num);

        /// <summary>
        /// Стандартные арифметические операторы
        /// </summary>
        public static CalculatorNumber operator +(CalculatorNumber left, CalculatorNumber right) 
            => new CalculatorNumber((left.ToDouble() + right.ToDouble()));
        public static CalculatorNumber operator -(CalculatorNumber left, CalculatorNumber right)
            => new CalculatorNumber((left.ToDouble() - right.ToDouble()));
        public static CalculatorNumber operator *(CalculatorNumber left, CalculatorNumber right)
            => new CalculatorNumber((left.ToDouble() * right.ToDouble()));
        public static CalculatorNumber operator /(CalculatorNumber left, CalculatorNumber right)
            => new CalculatorNumber((left.ToDouble() / right.ToDouble()));

        /// <summary>
        /// Приведение к Double
        /// </summary>
        /// <returns>Число с плавающей точкой</returns>
        public double ToDouble() => Convert.ToDouble(ToCalculatorFormat(_numStr));

        /// <summary>
        /// Приведение к строке
        /// </summary>
        /// <returns>Строка</returns>
        public override string ToString() => _numStr;

        /// <summary>
        /// Установка значения
        /// </summary>
        /// <param name="val">Значение</param>
        public void SetValue(double val) => _numStr = ToCalculatorFormat(val);

        /// <summary>
        /// Установка значения
        /// </summary>
        /// <param name="val">Значение</param>
        public void SetValue(CalculatorNumber val) => _numStr = val._numStr;

        /// <summary>
        /// Добавление символа к строке
        /// </summary>
        /// <param name="digit">Символ</param>
        public void Append(char digit)
        {
            if (_numStr.Length >= 16)
                return;

            if(digit == '.')
            {
                if (!_numStr.Contains(digit))
                    _numStr += digit;
                return;
            }

            if (!Char.IsDigit(digit))
                throw new NotADigitException();

            if (_numStr == "0")
                _numStr = digit.ToString();
            else
                _numStr += digit;
        }

        /// <summary>
        /// Удаление последнего символа из строки
        /// </summary>
        public void RemoveDigit()
        {
            if (_numStr == "")
                return;
            _numStr = _numStr.Remove(_numStr.Length - 1, 1);
            if (_numStr == "")
                _numStr = "0";
        }

        /// <summary>
        /// Приведение к формату, поддерживаемому калькулятором
        /// </summary>
        /// <param name="num">Число с плавающей точкой</param>
        /// <returns>Строка подходящего формата</returns>
        private string ToCalculatorFormat(double num)
        {
            if (Math.Round(num).ToString("F0").Length > 16 || Double.IsInfinity(num))
                throw new NumberOverflowException();
            if (Double.IsNaN(num))
                throw new NotANumberException();
            if (num == 0)
                return "0";

            var result = num.ToString("F17").Substring(0, 16);
            if(result.Contains('.'))
                result = result.TrimEnd('0').TrimEnd('.');

            return result;
        }

        /// <summary>
        /// Приведение к формату, поддерживаемому калькулятором
        /// </summary>
        /// <param name="num">Строка</param>
        /// <returns>Строка поддерживаемого формата</returns>
        private string ToCalculatorFormat(string num)
        {
            if (num.TakeWhile(ch => ch != '.').Count() > 16)
                throw new NumberOverflowException();

            if (!num.Contains('.'))
                return num;
            return num.TrimEnd('0').TrimEnd('.');
        }
    }
}
