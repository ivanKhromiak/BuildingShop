using BuildingShop.Domain.DomainObjects;
using System.Collections.Generic;

namespace BuildingShop.Web.Models
{
    public class OrderViewModel
    {
        public Order Order { get; set; }
        public Dictionary<string, string[]> DateInfo { get; set; }
    }
}
