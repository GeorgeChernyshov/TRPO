using DatabaseWork;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Chernyshov_DependencyInjunction_Database
{
    class Program
    {
        /// <summary>
        /// Путь по умолчанию
        /// </summary>
        private const string DEFAULT_PATH = @"..\..\input.txt";

        /// <summary>
        /// Предположим, нам требуется написать приложение, способное работать с различными СУБД: 
        /// Oracle, MySQL, PostgreSQL. При работе с базой данных приложению требуется 
        /// выполнение стандартных действий: создание БД, добавление таблицы и т.д. 
        /// Напишете часть программы, позволяющую встраивать объект, отвечающий за работу с конкретной СУБД, 
        /// в класс-контроллер для выполнения стандартных операций с БД. 
        /// Минимальное количество стандартных действий в любой БД: 10. 
        /// Методы работы с БД реализовывать не требуется, достаточно выводить на консоль 
        /// сообщение о вызове метода. 
        /// На вход программе подаётся название СУБД и список действий, 
        /// программа выводит на консоль сообщения о вызове методов соответствующего класса.
        ///Для решения задачи потребуется применение шаблона "Внедрение зависимостей".
        /// </summary>
        /// <param name="args">Аргументы для запуска</param>
        static void Main(string[] args)
        {
            string path;
            if (args.Length == 0)
                path = DEFAULT_PATH;
            else
                path = args[0];

            try
            {
                using (var sr = new StreamReader(path))
                {
                    var handler = new DatabaseWorkerHandler(DatabaseWorkerFactory.Create(sr.ReadLine()));
                    while (!sr.EndOfStream)
                    {
                        try
                        {
                            handler.Execute(sr.ReadLine());
                        }
                        catch (InvalidCommandException)
                        {
                            Console.WriteLine("Команды с таким названием не существует.");
                        }
                    }  
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine(String.Format("Не найден файл по пути {0}.", path));
            }
            catch (InvalidDatabaseTypeException)
            {
                Console.WriteLine("Указанный тип базы данных не поддерживается.");
            }
        }
    }
}
