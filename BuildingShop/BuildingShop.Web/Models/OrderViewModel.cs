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
        public List<Delivery> Deliveries { get; set; }
        public List<Purchase> Purchases { get; set; }
    }
}
