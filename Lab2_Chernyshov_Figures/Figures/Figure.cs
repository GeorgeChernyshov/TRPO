using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Helpers.HelpersExceptions;

namespace Figures
{
    /// <summary>
    /// Класс, обозначающий абстрактную фигуру
    /// </summary>
    public abstract class Figure
    {
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
        private readonly double width;

        /// <summary>
        /// Высота прямоугольника
        /// </summary>
        private readonly double height;
        
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="width">Ширина</param>
        /// <param name="height">Высота</param>
        public Rectangle(double width, double height)
        {
            if (width < 0 || height < 0)
                throw new NegativeNumberException();

            this.width = width;
            this.height = height;
        }

        public override double Perimeter => (width + height) * 2;
        public override double Area => width * height;
        public override string ToString() => String.Format(
            "Прямоугольник[ширина: {0}, высота: {1}, периметр: {2}, площадь: {3}]",
            width, height, Perimeter, Area);
    }

    /// <summary>
    /// Круг
    /// </summary>
    public class Circle : Figure
    {
        /// <summary>
        /// Радиус круга
        /// </summary>
        private readonly double radius;

        /// <summary>
        /// Конструкттор класса
        /// </summary>
        /// <param name="radius">Радиус</param>
        public Circle(double radius)
        {
            if (radius < 0)
                throw new NegativeNumberException();

            this.radius = radius;
        }

        public override double Perimeter => 2 * Math.PI * radius;
        public override double Area => Math.PI * Math.Pow(radius, 2);
        public override string ToString() => String.Format(
            "Круг[радиус: {0}, периметр: {1}, площадь: {2}]",
            radius, Perimeter, Area);
    }

    /// <summary>
    /// Треугольник
    /// </summary>
    public class Triangle : Figure
    {
        /// <summary>
        /// Ребра треугольника
        /// </summary>
        private readonly double edge1, edge2, edge3;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="edge1">Первое ребро</param>
        /// <param name="edge2">Второе ребро</param>
        /// <param name="edge3">Третье ребро</param>
        public Triangle(double edge1, double edge2, double edge3)
        {
            if (edge1 < 0 || edge2 < 0 || edge3 < 0)
                throw new NegativeNumberException();

            if (edge1 + edge2 + edge3 < 2*Math.Max(edge1, Math.Max(edge2, edge3)))
                throw new InvalidTriangleException();

            this.edge1 = edge1;
            this.edge2 = edge2;
            this.edge3 = edge3;
        }

        public override double Perimeter => edge1 + edge2 + edge3;
        public override double Area
        {
            get
            {
                double halfPerimeter = Perimeter / 2;
                return Math.Sqrt(
                      halfPerimeter 
                    * (halfPerimeter - edge1) 
                    * (halfPerimeter - edge2) 
                    * (halfPerimeter - edge3));
            }
        }

        public override string ToString() => String.Format(
            "Треугольник[Рёбра: {0}, {1}, {2}, периметр: {3}, площадь: {4}]",
            edge1, edge2, edge3, Perimeter, Area);

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
    }
}
