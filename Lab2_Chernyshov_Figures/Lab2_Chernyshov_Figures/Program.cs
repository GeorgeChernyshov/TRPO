using Figures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Helpers.Helpers;
using static Lab2_Chernyshov_Figures.Exceptions;

namespace Lab2_Chernyshov_Figures
{
    class Program
    {
        private static Figure ParseFigure(string line)
        {
            var args = line.Split(' ');
            switch(args[0])
            {
                case "Прямоугольник":
                    return new Rectangle(TryParseDouble(args[1]), TryParseDouble(args[2]));
                case "Круг":
                    return new Circle(TryParseDouble(args[1]));
                case "Треугольник":
                    return new Triangle(TryParseDouble(args[1]), TryParseDouble(args[2]), TryParseDouble(args[3]));
                default:
                    throw new IllegalFigureException();
            }
        }

        static void Main(string[] args)
        {
            int n;
            string inputFileName = "../../input.txt";

            try
            {
                using (var inputStream = new FileStream(inputFileName, FileMode.Open))
                using (var streamReader = new StreamReader(inputStream))
                {
                    n = TryParseInt(streamReader.ReadLine());
                    for (int i = 0; i < n; i++)
                    {
                        string line = streamReader.ReadLine();
                        try
                        {
                            Console.WriteLine(ParseFigure(line).ToString());
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(String.Format("Строка {0}: {1}", (i + 1).ToString(), e.Message));
                        }
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
