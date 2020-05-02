using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWork
{
    /// <summary>
    /// Класс для работы с базой данных Oracle
    /// </summary>
    public class OracleDatabaseWorker : IDatabaseWorker
    {
        #region IDatabaseWorker implementation
        public void AddToTable() => Console.WriteLine("Oracle Add to table");
        public void CreateTable() => Console.WriteLine("Oracle Create table");
        public void CreateUser() => Console.WriteLine("Oracle Create user");
        public void DeleteTable() => Console.WriteLine("Oracle Delete table");
        public void DeleteUser() => Console.WriteLine("Oracle Delete user");
        public void GrantRightsToUser() => Console.WriteLine("Oracle Grant rights to user");
        public void InvokeProcedure() => Console.WriteLine("Oracle Invoke procedure");
        public void RemoveFromTable() => Console.WriteLine("Oracle Remove from table");
        public void RemoveRightsFromUser() => Console.WriteLine("Oracle Remove rights from user");
        public void SelectFromTable() => Console.WriteLine("Oracle Select from table");
        #endregion
    }
}
