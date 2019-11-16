using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Websais.Models;

namespace Websaite.Controler
{
    public class HomeController : Controller
    {
       
            public HomeController() { }

                public IActionResult blog() => View();
             //   public IActionResult blog-single() => View();
                public IActionResult  cart() => View();
                public IActionResult checkout() => View();
           //     public IActionResult contact-us() => View();
            public IActionResult index() => View();
         //   public IActionResult product-details() => View();
            public IActionResult shop() => View();





    }
}