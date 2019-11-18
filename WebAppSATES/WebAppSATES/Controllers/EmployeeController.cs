using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebAppSATES.Models;

namespace WebAppSATES.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly List<EmployeeView> __Employees = new List<EmployeeView>
            {
            new EmployeeView
            {

             Id=1,
             FirstName="Василий",
             SecondName="Иванов",
             Patronymic="Иванович",
             Age=52
                     },

             new EmployeeView
            {

             Id=1,
             FirstName="Иван",
            SecondName="Иванов",
             Patronymic="Иванович",
             Age=22
                     }


            };
        public IActionResult Index()
        {
            ViewBag.SomeData = "Hello World!";
            ViewData["Test"] = "TestData";

            return View();
        }
    }
}