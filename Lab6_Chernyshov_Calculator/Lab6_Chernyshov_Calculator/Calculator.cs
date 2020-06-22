using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// Калькулятор
    /// </summary>
    class Calculator
    {
        /// <summary>
        /// Пользовательский интерфейс
        /// </summary>
        private CalculatorWindow _window;

        /// <summary>
        /// Арифметические операции
        /// </summary>
        private Dictionary<char, Action> _operations;

        /// <summary>
        /// Результат предыдущей операции 
        /// </summary>
        private CalculatorNumber _buffer;

        /// <summary>
        /// Текущий операнд
        /// </summary>
        private CalculatorNumber _current;

        /// <summary>
        /// Текущая операция
        /// </summary>
        private string _op;

        public Calculator()
        {
            _buffer = new CalculatorNumber();
            _op = "";
            _current = new CalculatorNumber(0);
            _operations = new Dictionary<char, Action>
            {
                { '+', () => _buffer += _current },
                { '-', () => _buffer -= _current },
                { '*', () => _buffer *= _current },
                { '/', () => _buffer /= _current },
                { '=', () => _buffer.SetValue(_current) },
                { (char)Keys.Enter, () => _buffer.SetValue(_current) }
            };

            _window = new CalculatorWindow();
            _window.InputHandler += (keyCode => HandleInput(keyCode));
            _window.UpdateDisplay(_buffer.ToString(), _op, _current.ToString());
        }

        /// <summary>
        /// Открытие калькулятора для работы пользователя 
        /// </summary>
        public void Open()
        {
            CultureInfo.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            _window.Show();
        }

        /// <summary>
        /// Обработка входящего сигнала
        /// </summary>
        /// <param name="key">Сигнал</param>
        private void HandleInput(char key)
        {
            try
            {
                if (Char.IsDigit(key) || key == '.')
                    _current.Append(key);
                else if (key == (char)Keys.Back)
                    _current.RemoveDigit();
                else if (key == (char)0)
                    _current.SetValue(0);
                else if (_operations.ContainsKey(key))
                    HandleOperation(key);
                _window.UpdateDisplay(_buffer.ToString(), _op, _current.ToString());
            }
            catch(NumberOverflowException)
            {
                _buffer = new CalculatorNumber();
                _current.SetValue(0);
                _op = "";
                _window.UpdateDisplay("OVERFLOW", _op, _current.ToString());
            }
            catch(NotANumberException)
            {
                _buffer = new CalculatorNumber();
                _current.SetValue(0);
                _op = "";
                _window.UpdateDisplay("NaN", _op, _current.ToString());
            }
        }

        /// <summary>
        /// Обработка арифметической операции
        /// </summary>
        /// <param name="key">Ключ операции</param>
        private void HandleOperation(char key)
        { 
            if (_op == "")
                _buffer.SetValue(_current);
            else
                _operations[_op.First()]();
            _current.SetValue(0);
            _op = key.ToString();
        }
    }
}
