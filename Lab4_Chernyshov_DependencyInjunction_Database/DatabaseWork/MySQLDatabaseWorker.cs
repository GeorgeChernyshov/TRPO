using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWork
{
    /// <summary>
    /// Класс для работы с базой данный MySQL
    /// </summary>
    public class MySQLDatabaseWorker : IDatabaseWorker
    {
        #region IDatabaseWorker implementation
        public void AddToTable() => Console.WriteLine("MySQL Add to table");
        public void CreateTable() => Console.WriteLine("MySQL Create table");
        public void CreateUser() => Console.WriteLine("MySQL Create user");
        public void DeleteTable() => Console.WriteLine("MySQL Delete table");
        public void DeleteUser() => Console.WriteLine("MySQL Delete user");
        public void GrantRightsToUser() => Console.WriteLine("MySQL Grant rights to user");
        public void InvokeProcedure() => Console.WriteLine("MySQL Invoke procedure");
        public void RemoveFromTable() => Console.WriteLine("MySQL Remove from table");
        public void RemoveRightsFromUser() => Console.WriteLine("MySQL Remove rights from user");
        public void SelectFromTable() => Console.WriteLine("MySQL Select from table");
        #endregion
    }
}
