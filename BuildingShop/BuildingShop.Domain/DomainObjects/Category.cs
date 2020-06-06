using System.Collections.Generic;

namespace BuildingShop.Domain.DomainObjects
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }

        public List<Product> Products { get; set; }
    }
}
