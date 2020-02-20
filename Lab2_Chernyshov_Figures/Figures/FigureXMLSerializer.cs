using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static Figures.FigureExceptions;

namespace Figures
{
    /// <summary>
    /// Класс, осуществляющий сериализацию любой фигуры
    /// </summary>
    public class FigureXMLSerializer
    {
        /// <summary>
        /// Сериализатор прямоугольников
        /// </summary>
        private XmlSerializer rectangleSerializer;

        /// <summary>
        /// Сериализатор кругов
        /// </summary>
        private XmlSerializer circleSerializer;

        /// <summary>
        /// Сериализатор треугольников
        /// </summary>
        private XmlSerializer triangleSerializer;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public FigureXMLSerializer()
        {
            rectangleSerializer = new XmlSerializer(typeof(Rectangle));
            circleSerializer = new XmlSerializer(typeof(Circle));
            triangleSerializer = new XmlSerializer(typeof(Triangle));
        }

        public void Serialize(Stream stream, Object o)
        {
            switch(o.GetType().Name)
            {
                case "Rectangle":
                    rectangleSerializer.Serialize(stream, o);
                    break;
                case "Circle":
                    circleSerializer.Serialize(stream, o);
                    break;
                case "Triangle":
                    triangleSerializer.Serialize(stream, o);
                    break;
                default:
                    throw new IllegalFigureException();
            }
        }
    }
}
