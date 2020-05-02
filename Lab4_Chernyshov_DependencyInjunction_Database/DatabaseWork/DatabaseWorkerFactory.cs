using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWork
{
    /// <summary>
    /// Фабрика для создания объектов реализующих интерфейс IDatabaseWorker
    /// </summary>
    public static class DatabaseWorkerFactory
    {
        /// <summary>
        /// Словарь лямбда-функций, возвращающих IDatabaseWorker
        /// </summary>
        private static Dictionary<string, Func<IDatabaseWorker>> objectTypes =
            new Dictionary<string, Func<IDatabaseWorker>>
            {
                { DatabaseTypes.MySQL, () => new MySQLDatabaseWorker() },
                { DatabaseTypes.Oracle, () => new OracleDatabaseWorker() },
                { DatabaseTypes.Postgres, () => new PostgresDatabaseWorker() }
            };

        /// <summary>
        /// Создание объекта
        /// </summary>
        /// <param name="type">Класс объекта</param>
        /// <returns>Новый экземпляр IDataBaseWorker</returns>
        public static IDatabaseWorker Create(string type)
        {
            if(!objectTypes.ContainsKey(type))
                throw new InvalidDatabaseTypeException();

            return objectTypes[type]();
        }
    }
}
