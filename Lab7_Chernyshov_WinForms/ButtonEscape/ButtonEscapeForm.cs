using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEscape
{
    /// <summary>
    /// Окно с игрой
    /// </summary>
    public partial class ButtonEscapeForm : Form
    {
        /// <summary>
        /// Позиция курсора в предыдущий момент времени
        /// </summary>
        private Point _prevMousePos;

        /// <summary>
        /// Высота меню
        /// </summary>
        private const int _headerHight = 40;

        /// <summary>
        /// Логика игры
        /// </summary>
        private GameLogic _logic;

        public ButtonEscapeForm()
        {
            InitializeComponent();
            _logic = new GameLogic(this, 
                this.Width - winButton.Width, 
                this.Height - winButton.Height - _headerHight
            );
        }

        private void WinButton_Click(object sender, EventArgs e)
        {
            var victoryDialog = MessageBox.Show(
                "Поздравляем! Вы смогли нажать на кнопку!", 
                "Поздравляем", 
                MessageBoxButtons.OK
            );
            if (victoryDialog == DialogResult.OK)
                this.Close();
        }

        private void ButtonEscapeForm_Load(object sender, EventArgs e) => _logic.Reload();

        private void ButtonEscapeForm_MouseMove(object sender, MouseEventArgs e)
        {
            var direction = new Point(
                MousePosition.X - _prevMousePos.X,
                MousePosition.Y - _prevMousePos.Y
            );

            _logic.Move(direction);
            _prevMousePos = MousePosition;
        }

        /// <summary>
        /// Обновление позиции кнопки
        /// </summary>
        public void UpdatePos() => MoveButton(_logic.Pos);

        /// <summary>
        /// Пемещение кнопки</summary>
        /// <param name="pos">Точка, на которую переместится кнопка</param>
        private void MoveButton(Point pos) => winButton.Location = pos;
    }
}
