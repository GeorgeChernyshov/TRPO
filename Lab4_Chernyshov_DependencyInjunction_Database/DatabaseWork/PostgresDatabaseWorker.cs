using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWork
{
    /// <summary>
    /// Класс для работы с базой данных Postgres
    /// </summary>
    public class PostgresDatabaseWorker : IDatabaseWorker
    {
        #region IDatabaseWorker implementation
        public void AddToTable() => Console.WriteLine("Postgres Add to table");
        public void CreateTable() => Console.WriteLine("Postgres Create table");
        public void CreateUser() => Console.WriteLine("Postgres Create user");
        public void DeleteTable() => Console.WriteLine("Postgres Delete table");
        public void DeleteUser() => Console.WriteLine("Postgres Delete user");
        public void GrantRightsToUser() => Console.WriteLine("Postgres Grant rights to user");
        public void InvokeProcedure() => Console.WriteLine("Postgres Invoke procedure");
        public void RemoveFromTable() => Console.WriteLine("Postgres Remove from table");
        public void RemoveRightsFromUser() => Console.WriteLine("Postgres Remove rights from user");
        public void SelectFromTable() => Console.WriteLine("Postgres Select from table");
        #endregion
    }
}
