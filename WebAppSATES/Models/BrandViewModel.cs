﻿using WebAppSATES.Domain.Entities.Base.Interfaces;

namespace WebAppSATES.Models
{
    public class BrandViewModel : INamedEntity, IOrderedEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Order { get; set; }
    }
}
