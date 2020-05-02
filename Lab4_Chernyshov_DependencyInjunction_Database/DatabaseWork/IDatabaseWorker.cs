using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseWork
{
    /// <summary>
    /// Интерфейс-обертка для работы с базой данных
    /// </summary>
    public interface IDatabaseWorker
    {
        /// <summary>
        /// Добавление в таблицу
        /// </summary>
        void AddToTable();

        /// <summary>
        /// Создание таблицы
        /// </summary>
        void CreateTable();

        /// <summary>
        /// Создание пользователя
        /// </summary>
        void CreateUser();

        /// <summary>
        /// Удаление таблицы
        /// </summary>
        void DeleteTable();

        /// <summary>
        /// Удаление пользователя
        /// </summary>
        void DeleteUser();

        /// <summary>
        /// Добавление прав пользователю
        /// </summary>
        void GrantRightsToUser();

        /// <summary>
        /// Выполнение процедуры
        /// </summary>
        void InvokeProcedure();

        /// <summary>
        /// Удаление из таблицы
        /// </summary>
        void RemoveFromTable();

        /// <summary>
        /// Удаление прав пользователя
        /// </summary>
        void RemoveRightsFromUser();

        /// <summary>
        /// Получение данных из таблицы
        /// </summary>
        void SelectFromTable();
    }
}
