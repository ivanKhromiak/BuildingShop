using System.Collections.Generic;

namespace BuildingShop.Domain.DomainObjects
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }

        public string Image { get; set; }

        public decimal Price { get; set; }

        public int Amount { get; set; }

        public int CategoryId { get; set; }

        public Category Category { get; set; }

        public Dictionary<string, string> Сharacteristics { get; set; }
    }
}
