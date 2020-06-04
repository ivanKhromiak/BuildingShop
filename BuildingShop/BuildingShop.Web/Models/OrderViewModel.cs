using BuildingShop.Domain.DomainObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildingShop.Web.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public Dictionary<string, int[]> DateInfo { get; set; }
    }
}
