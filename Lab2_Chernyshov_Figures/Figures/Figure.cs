using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static Helpers.HelpersExceptions;

namespace Figures
{
    /// <summary>
    /// Класс, обозначающий абстрактную фигуру
    /// </summary>
    public abstract class Figure
    {
        /// <summary>
        /// Делегат
        /// </summary>
        private delegate void FigureHandler();

        /// <summary>
        /// Событие, вызываемое при создании экземпляра класса
        /// </summary>
        private event FigureHandler OnCreateEvent;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public Figure() => OnCreateEvent += Figure_OnCreate;

        /// <summary>
        /// Функция-обертка над событием OnCreateEvent
        /// </summary>
        protected virtual void OnCreate() => OnCreateEvent.Invoke();

        /// <summary>
        /// Функция, выводящая в лог запись о создании экземпляра класса
        /// </summary>
        private void Figure_OnCreate() => 
            Trace.WriteLine("Создан экзмепляр класса " + this.GetType().Name);

        /// <summary>
        /// Периметр фигуры
        /// </summary>
        public abstract double Perimeter { get; }

        /// <summary>
        /// Площадь фигуры
        /// </summary>
        public abstract double Area { get; }

        public override string ToString() => "Фигура";
    }

    /// <summary>
    /// Прямоугольник. Задаётся шириной и высотой
    /// </summary>
    public class Rectangle : Figure
    {
        /// <summary>
        /// Ширина прямоугольника
        /// </summary>
        [XmlElement]
        public double Width { get; set; }

        /// <summary>
        /// Высота прямоугольника
        /// </summary>
        [XmlElement]
        public double Height { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        public Rectangle(double width, double height) : base()
        {
            if (width < 0 || height < 0)
                throw new NegativeNumberException();

            Width = width;
            Height = height;
            OnCreate();
        }

        /// <summary>
        /// Конструктор без параметров.
        /// </summary>
        public Rectangle() : base()
        {
            Width = 1;
            Height = 1;
            OnCreate();
        }

        public override double Perimeter => (Width + Height) * 2;
        public override double Area => Width * Height;
        public override string ToString() => String.Format(
            "Прямоугольник[ширина: {0}, высота: {1}, периметр: {2}, площадь: {3}]",
            Width, Height, Perimeter, Area);

        /// <summary>
        /// Функция-обертка над событием OnCreateEvent
        /// </summary>
        protected override void OnCreate() => base.OnCreate();
    }

    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        [XmlElement]
        public double Radius { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius) : base()
        {
            if (radius < 0)
                throw new NegativeNumberException();

            Radius = radius;
            OnCreate();
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Circle() : base()
        {
            Radius = 1;
            OnCreate();
        }

        public override double Perimeter => 2 * Math.PI * Radius;
        public override double Area => Math.PI * Math.Pow(Radius, 2);
        public override string ToString() => String.Format(
            "Круг[радиус: {0}, периметр: {1}, площадь: {2}]",
            Radius, Perimeter, Area);

        /// <summary>
        /// Функция-обертка над событием OnCreateEvent
        /// </summary>
        protected override void OnCreate() => base.OnCreate();
    }

    /// <summary>
    /// Треугольник
    /// </summary>
    [Serializable]
    public class Triangle : Figure
    {
        /// <summary>
        /// Ребра треугольника
        /// </summary>
        [XmlElement]
        public double Edge1 { get; set; }
        [XmlElement]
        public double Edge2 { get; set; }
        [XmlElement]
        public double Edge3 { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="edge1">Первое ребро</param>
        /// <param name="edge2">Второе ребро</param>
        /// <param name="edge3">Третье ребро</param>
        public Triangle(double edge1, double edge2, double edge3) : base()
        {
            if (edge1 < 0 || edge2 < 0 || edge3 < 0)
                throw new NegativeNumberException();

            if (edge1 + edge2 + edge3 < 2*Math.Max(edge1, Math.Max(edge2, edge3)))
                throw new InvalidTriangleException();

            Edge1 = edge1;
            Edge2 = edge2;
            Edge3 = edge3;

            OnCreate();
        }

        /// <summary>
        /// Конструктор без параметров
        /// </summary>
        public Triangle() : base()
        {
            Edge1 = 1;
            Edge2 = 1;
            Edge3 = 1;
            OnCreate();
        }

        public override double Perimeter => Edge1 + Edge2 + Edge3;
        public override double Area
        {
            get
            {
                double halfPerimeter = Perimeter / 2;
                return Math.Sqrt(
                      halfPerimeter 
                    * (halfPerimeter - Edge1) 
                    * (halfPerimeter - Edge2) 
                    * (halfPerimeter - Edge3));
            }
        }

        public override string ToString() => String.Format(
            "Треугольник[Рёбра: {0}, {1}, {2}, периметр: {3}, площадь: {4}]",
            Edge1, Edge2, Edge3, Perimeter, Area);

        /// <summary>
        /// Исключение, бросаемое в случае, когда треугольника с заданными длинами сторон не существует.
        /// </summary>
        private class InvalidTriangleException : Exception
        {
            /// <summary>
            /// Сообщение об ошибке
            /// </summary>
            const string message = "Треугольника с такими сторонами не существует";

            /// <summary>
            /// Конструктор класса
            /// </summary>
            public InvalidTriangleException() : base(message) { }
        }

        /// <summary>
        /// Функция-обертка над событием OnCreateEvent
        /// </summary>
        protected override void OnCreate() => base.OnCreate();
    }
}
