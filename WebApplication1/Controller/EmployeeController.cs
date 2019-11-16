using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Websais.Models;
namespace Websais.Controller
{
    public class EmployeeController //:Controller
    {
        private readonly List<EmployeeView> _employees = new List<EmployeeView>
                {
                new EmployeeView
                {
                Id = 1,
                FirstName = "Иван" ,
                SurName = "Иванов" ,
                Patronymic = "Иванович" ,
                Age = 100
                },
                new EmployeeView
                {
                Id = 2,
                FirstName = "Петор" ,
                SurName = "Петров" ,
                Patronymic = "Иванович" ,
                Age = 100
                }
                };
       /* public IActionResult Index()
        {
            return View(_employees);
        }*/
    }
}