﻿using System.Collections.Generic;
using WebAppSATES.Models;

namespace WebAppSATES.Infrastructure.Interfaces
{
    /// <summary>Сервис сотрудников</summary>
    public interface IEmployeesData
    {
        /// <summary>Получить всех сотрудников</summary>
        /// <returns>Перечисление сотрудников, известных сервису</returns>
        IEnumerable<Employee> GetAll();

        /// <summary>Найти сотрудника по его идентификатору</summary>
        /// <param name="id">Идентификатор сотрудника</param>
        /// <returns>Сотрудник с указанным идентификатором, либо null</returns>
        Employee GetById(int id);

        /// <summary>Добавление нового сотрудника в сервис</summary>
        /// <param name="Employee">Добавляемый сотрудник</param>
        void Add(Employee Employee);

        /// <summary>Редактирование данных сотрудника по указанному идентификатору</summary>
        /// <param name="id">Идентификатор редактируемого сотрудника</param>
        /// <param name="Employee">Модель с данными сотрудника, которые надо внести в сервис</param>
        void Edit(int id, Employee Employee);

        /// <summary>Удаление сотрудника по заданному идентификатору</summary>
        /// <param name="id">Идентификатор удаляемого сотрудника</param>
        bool Delete(int id);

        /// <summary>Сохранить изменения</summary>
        void SaveChanges();
    }
}
