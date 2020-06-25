using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrownianMotionSimulation
{
    class Molecule
    {
        /// <summary>
        /// Позиция по оси X
        /// </summary>
        public float X { get; private set; }

        /// <summary>
        /// Позиция по оси Y
        /// </summary>
        public float Y { get; private set; }

        /// <summary>
        /// Масса молекулы
        /// </summary>
        private int Mass { get; }

        /// <summary>
        /// Диаметр молекулы
        /// </summary>
        public float Diameter { get => 3 * (float)Math.Sqrt(Convert.ToDouble(Mass)); }

        /// <summary>
        /// Предоставлена ли молекула к удалению
        /// </summary>
        public bool ToDelete { get; set; }

        /// <summary>
        /// Скорость молекулы
        /// </summary>
        public int Speed { get; set; }

        /// <summary>
        /// Молекула
        /// </summary>
        /// <param name="x">Позиция по оси X</param>
        /// <param name="y">Позиция по оси Y</param>
        /// <param name="mass">Масса</param>
        public Molecule(float x, float y, int mass)
        {
            X = x;
            Y = y;
            Mass = mass;
            ToDelete = false;
        }

        /// <summary>
        /// Передвинуть молекулу
        /// </summary>
        /// <param name="direction">Направление</param>
        /// <param name="distance">Расстояние</param>
        public void Move(float direction, float distance)
        {
            float totalDistance = distance / Mass;
            float xMovement = (float)(totalDistance * Math.Cos((double)direction));
            float yMovement = (float)(totalDistance * Math.Sin((double)direction));
            X += xMovement;
            Y += yMovement;
        }
    }
}
