using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ButtonEscape
{
    class GameLogic
    {
        /// <summary>
        /// Форма-родитель
        /// </summary>
        private ButtonEscapeForm _form;

        /// <summary>
        /// Ширина поля
        /// </summary>
        private int _maxWidth;

        /// <summary>
        /// Высота поля
        /// </summary>
        private int _maxHeight;

        /// <summary>
        /// Позиция на поле
        /// </summary>
        private Point _pos;

        /// <summary>
        /// 
        /// </summary>
        private BackgroundWorker _worker;

        /// <summary>
        /// Направления поворота
        /// </summary>
        private enum RotationDirection
        {
            Clockwise,
            CounterClockwise
        };

        /// <summary>
        /// Направление поворота при коллизии
        /// </summary>
        private RotationDirection _rotation;

        /// <summary>
        /// Направление поворота при коллизии
        /// </summary>
        private RotationDirection Rotation
        {
            get
            {
                lock (this)
                {
                    return _rotation;
                }
            }
        }

        /// <summary>
        /// Состояния коллизий
        /// </summary>
        private enum CollisionStatuses
        {
            Top,
            Bottom,
            Left,
            Right,
            OK
        }

        /// <summary>
        /// Текущее состояние коллизии
        /// </summary>
        private CollisionStatuses CollisionStatus
        {
            get
            {
                if (_pos.Y < 0)
                    return CollisionStatuses.Top;
                if (_pos.Y > _maxHeight)
                    return CollisionStatuses.Bottom;
                if (_pos.X < 0)
                    return CollisionStatuses.Left;
                if (_pos.X > _maxWidth)
                    return CollisionStatuses.Right;
                return CollisionStatuses.OK;
            }
        }

        /// <summary>
        /// Позиция объекта на поле
        /// </summary>
        public Point Pos { get => _pos; }
        
        public GameLogic(ButtonEscapeForm form, int width, int height)
        {
            this._form = form;
            this._maxWidth = width;
            this._maxHeight = height;
            _pos = new Point(0, 0);
            _worker = new BackgroundWorker();
            _worker.DoWork += new DoWorkEventHandler(ChooseDirection);
            _worker.RunWorkerAsync();
        }

        /// <summary>
        /// Перезагрузка игры
        /// </summary>
        public void Reload()
        {
            _pos.X = _maxWidth / 2;
            _pos.Y = _maxHeight / 2;
            _form.UpdatePos();
        }

        /// <summary>
        /// Перемещение объекта на вектор
        /// </summary>
        /// <param name="direction">Вектор, на который происходит перемещение</param>
        public void Move(Point direction)
        {
            _pos.X += direction.X;
            _pos.Y += direction.Y;
            HandleWallCollision();
            _form.UpdatePos();
        }

        /// <summary>
        /// Обработка столкновения со стеной
        /// </summary>
        private void HandleWallCollision()
        {
            var rotation = Rotation;
            while (CollisionStatus != CollisionStatuses.OK)
            {
                if (CollisionStatus == CollisionStatuses.Top)
                {
                    _pos.X -= _pos.Y * ((rotation == RotationDirection.Clockwise) ? 1 : -1);
                    _pos.Y = 0;
                }
                else if (CollisionStatus == CollisionStatuses.Right)
                {
                    _pos.Y += (_pos.X - _maxWidth) * ((rotation == RotationDirection.Clockwise) ? 1 : -1);
                    _pos.X = _maxWidth;
                }
                else if (CollisionStatus == CollisionStatuses.Bottom)
                {
                    _pos.X -= (_pos.Y - _maxHeight) * ((rotation == RotationDirection.Clockwise) ? 1 : -1);
                    _pos.Y = _maxHeight;
                }
                else if (CollisionStatus == CollisionStatuses.Left)
                {
                    _pos.Y += _pos.X * ((rotation == RotationDirection.Clockwise) ? 1 : -1);
                    _pos.X = 0;
                }
            }
        }

        /// <summary>
        /// Выбор направления движения после столкновения со стеной
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseDirection(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                lock (this)
                {
                    if (new Random().NextDouble() > 0.5)
                        _rotation = RotationDirection.Clockwise;
                    else
                        _rotation = RotationDirection.CounterClockwise;
                }

                Task.Delay(1000).Wait();
            }
        }
    }
}
