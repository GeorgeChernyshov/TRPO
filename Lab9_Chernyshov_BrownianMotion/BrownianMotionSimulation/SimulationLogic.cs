using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BrownianMotionSimulation
{
    class SimulationLogic
    {
        /// <summary>
        /// Скорость молекул в симуляции
        /// </summary>
        private int _maxSpeed;

        /// <summary>
        /// Ширина поля
        /// </summary>
        public float Width { get; set; }

        /// <summary>
        /// Высота поля
        /// </summary>
        public float Height { get; set; }

        /// <summary>
        /// Интерфейс изменения скорости молекул
        /// </summary>
        public int Speed 
        {
            get => _maxSpeed;
            set
            {
                _maxSpeed = value + 1;
                foreach(var molecule in Molecules)
                {
                    lock(molecule)
                    {
                        molecule.Speed = value + 1;
                    }
                }
            }
        }

        /// <summary>
        /// Список молекул в симуляции
        /// </summary>
        public List<Molecule> Molecules { get; private set; }

        /// <summary>
        /// Задачи, перемещающие молекулы
        /// </summary>
        private Dictionary<Molecule, Task> _movementTasks;

        /// <summary>
        /// Логика симуляции
        /// </summary>
        /// <param name="width">Ширина поля</param>
        /// <param name="height">Высота поля</param>
        public SimulationLogic(float width, float height)
        {
            Width = width;
            Height = height;
            _movementTasks = new Dictionary<Molecule, Task>();
            Molecules = new List<Molecule>();
        }

        /// <summary>
        /// Создание молекулы
        /// </summary>
        public void CreateMolecule()
        {
            Random r = new Random((int)DateTime.Now.Ticks + Molecules.Count);
            var molecule = new Molecule(
                (float)(r.NextDouble() * Width),
                (float)(r.NextDouble() * Height),
                r.Next() % 30);
            molecule.Speed = _maxSpeed;

            Molecules.Add(molecule);
            _movementTasks.Add(
                molecule, 
                Task.Factory.StartNew(() => SimulateMovement(molecule, r)));
        }

        /// <summary>
        /// Симуляция движения молекулы
        /// </summary>
        /// <param name="molecule">Молекула</param>
        /// <param name="random">Рандом</param>
        private void SimulateMovement(Molecule molecule, Random random)
        {
            float direction, speed;
            while(true)
            {
                lock(molecule)
                {
                    if (molecule.ToDelete)
                        return;

                    direction = (float)(random.NextDouble() * 2 * Math.PI);
                    speed = (float)(random.Next() % molecule.Speed);
                    molecule.Move(direction, speed);
                }

                Task.Delay(15);
            }
        }

        /// <summary>
        /// Изменение числа молекул
        /// </summary>
        /// <param name="count"></param>
        public void SetMoleculeCount(int count)
        {
            if(count >= Molecules.Count)
            {
                for (int i = 0; i < (count - Molecules.Count); i++)
                    CreateMolecule();
            }
            else
            {
                var toDelete = Molecules.Skip(count).ToArray();
                foreach(var m in toDelete)
                    m.ToDelete = true;

                Task.WaitAll(toDelete.Select(m => _movementTasks[m]).ToArray());

                foreach (var m in toDelete)
                {
                    _movementTasks.Remove(m);
                    Molecules.Remove(m);
                }
            }
        }
    }
}
