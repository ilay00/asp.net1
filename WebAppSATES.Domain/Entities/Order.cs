﻿using System;
using System.Collections.Generic;
using WebAppSATES.Domain.Entities.Base;
using WebAppSATES.Domain.Entities.Identity;

namespace WebAppSATES.Domain.Entities
{
    public class Order : NamedEntity
    {
        public virtual User User { get; set; }

        public string Phone { get; set; }

        public string Address { get; set; }

        public DateTime Date { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}