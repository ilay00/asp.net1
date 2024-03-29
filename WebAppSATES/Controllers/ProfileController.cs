﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebAppSATES.Domain.Entities;
using WebAppSATES.Infrastructure.Interfaces;
using WebAppSATES.Models;

namespace WebAppSATES.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult Orders([FromServices] IOrderService OrderService) =>
            View(OrderService
               .GetUserOrders(User.Identity.Name)
               .Select(order => new UserOrderViewModel
                {
                    Id = order.Id,
                    Name = order.Name,
                    Address = order.Address,
                    Phone = order.Phone,
                    TotalSum = order.OrderItems.Sum(item => item.Price * item.Quantity)
                }));
    }
}