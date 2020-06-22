using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    /// <summary>
    /// GUI калькулятора
    /// </summary>
    public partial class CalculatorWindow : Form
    {
        /// <summary>
        /// Высота дисплея
        /// </summary>
        private int _displayHeight = 84;

        /// <summary>
        /// Таблица кнопок
        /// </summary>
        private Button[,] _buttonTable;

        /// <summary>
        /// Обработчик нажатий
        /// </summary>
        public Action<char> InputHandler;
        public CalculatorWindow()
        {
            InitializeComponent();
            bufferDisplay.Text = "";
            operationDisplay.Text = "";
            ioDisplay.Text = "";

            _buttonTable = new Button[,]
            {
                { sevenButton, eightButton, nineButton, plusButton },
                { fourButton, fiveButton, sixButton, minusButton },
                { oneButton, twoButton, threeButton, multiplyButton },
                { eraseButton, zeroButton, delimeterButton, divideButton },
                { equalsButton, null, null, null }
            };
        }

        /// <summary>
        /// Запуск калькулятора
        /// </summary>
        public new void Show()
        {
            Application.Run(this);
        }

        //Обработчики нажатий
        private void OneButton_Click(object sender, EventArgs e) => InputHandler.Invoke('1');
        private void TwoButton_Click(object sender, EventArgs e) => InputHandler.Invoke('2');
        private void ThreeButton_Click(object sender, EventArgs e) => InputHandler.Invoke('3');
        private void FourButton_Click(object sender, EventArgs e) => InputHandler.Invoke('4');
        private void FiveButton_Click(object sender, EventArgs e) => InputHandler.Invoke('5');
        private void SixButton_Click(object sender, EventArgs e) => InputHandler.Invoke('6');
        private void SevenButton_Click(object sender, EventArgs e) => InputHandler.Invoke('7');
        private void EightButton_Click(object sender, EventArgs e) => InputHandler.Invoke('8');
        private void NineButton_Click(object sender, EventArgs e) => InputHandler.Invoke('9');
        private void ZeroButton_Click(object sender, EventArgs e) => InputHandler.Invoke('0');
        private void PlusButton_Click(object sender, EventArgs e) => InputHandler.Invoke('+');
        private void MinusButton_Click(object sender, EventArgs e) => InputHandler.Invoke('-');
        private void MultiplyButton_Click(object sender, EventArgs e) => InputHandler.Invoke('*');
        private void DivideButton_Click(object sender, EventArgs e) => InputHandler.Invoke('/');
        private void DelimeterButton_Click(object sender, EventArgs e) => InputHandler.Invoke('.');
        private void EraseButton_Click(object sender, EventArgs e) => InputHandler.Invoke((char)0);
        private void EqualsButton_Click(object sender, EventArgs e) => InputHandler.Invoke('=');
        private void CalculatorWindow_KeyPress(object sender, KeyPressEventArgs e) => InputHandler.Invoke(e.KeyChar);

        /// <summary>
        /// Обновление дисплея
        /// </summary>
        /// <param name="buffer">Буффер</param>
        /// <param name="op">Операция</param>
        /// <param name="current">Текущее значение</param>
        public void UpdateDisplay(string buffer, string op, string current)
        {
            bufferDisplay.Text = buffer;
            operationDisplay.Text = op;
            ioDisplay.Text = current;
        }

        private void CalculatorWindow_Resize(object sender, EventArgs e)
        {
            int buttonPanelHeight = this.Height - _displayHeight - 40;
            int buttonPanelWidth = this.Width - 30;
            int buttonHeight = (buttonPanelHeight - 30) / 5;
            int buttonWidth = (buttonPanelWidth - 18) / 4;

            for (int y = 0; y < 5; y++)
            {
                int rowTop = _displayHeight + (buttonHeight + 6) * y;
                for (int x = 0; x < 4; x++)
                {
                    if (_buttonTable[y, x] == null)
                        continue;

                    _buttonTable[y, x].Top = rowTop;
                    _buttonTable[y, x].Left = 6 + (buttonWidth + 6) * x;
                    _buttonTable[y, x].Height = buttonHeight;
                    _buttonTable[y, x].Width = buttonWidth;
                }
            }

            equalsButton.Width = buttonPanelWidth;
        }
    } 
}
