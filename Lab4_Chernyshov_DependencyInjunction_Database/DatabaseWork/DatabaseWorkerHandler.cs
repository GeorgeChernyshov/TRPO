using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWork
{
    /// <summary>
    /// Класс-обертка между пользовательским уровнем и уровнем приложения
    /// </summary>
    public class DatabaseWorkerHandler
    {
        /// <summary>
        /// Обслуживаемый класс
        /// </summary>
        private IDatabaseWorker worker;

        /// <summary>
        /// Словарь, соотносящий команды и строковые литералы-аргументы
        /// </summary>
        private Dictionary<string, Action<IDatabaseWorker>> commands =
            new Dictionary<string, Action<IDatabaseWorker>>
            {
                { Commands.AddToTable, worker => worker.AddToTable() },
                { Commands.CreateTable, worker => worker.CreateTable() },
                { Commands.CreateUser, worker => worker.CreateUser() },
                { Commands.DeleteTable, worker => worker.DeleteTable() },
                { Commands.DeleteUser, worker => worker.DeleteUser() },
                { Commands.GrantRightsToUser, worker => worker.GrantRightsToUser() },
                { Commands.InvokeProcedure, worker => worker.InvokeProcedure() },
                { Commands.RemoveFromTable, worker => worker.RemoveFromTable() },
                { Commands.RemoveRightsFromUser, worker => worker.RemoveRightsFromUser() },
                { Commands.SelectFromTable, worker => worker.SelectFromTable() }
            };

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="worker">объект IDatabaseWorker</param>
        public DatabaseWorkerHandler(IDatabaseWorker worker) => this.worker = worker;

        public void Execute(string line)
        {
            if (!commands.ContainsKey(line))
                throw new InvalidCommandException();

            commands[line](worker);
        }
    }
}
