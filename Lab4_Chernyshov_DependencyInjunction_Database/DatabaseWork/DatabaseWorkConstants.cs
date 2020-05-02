using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWork
{
    /// <summary>
    /// Типы БД, с которыми работает приложение
    /// </summary>
    public static class DatabaseTypes
    {
        public const string MySQL = "MySQL";
        public const string Oracle = "Oracle";
        public const string Postgres = "Postgres";
    }

    /// <summary>
    /// Виды исполняемых команд
    /// </summary>
    public static class Commands
    {
        public const string AddToTable = "add";
        public const string CreateTable = "createtable";
        public const string CreateUser = "createuser";
        public const string DeleteTable = "deletetable";
        public const string DeleteUser = "deleteuser";
        public const string GrantRightsToUser = "grantrights";
        public const string InvokeProcedure = "invoke";
        public const string RemoveFromTable = "remove";
        public const string RemoveRightsFromUser = "removerights";
        public const string SelectFromTable = "select";
    }
}
