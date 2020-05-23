﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingShop.Domain.DomainObjects
{
    public class Category: BaseEntity
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
