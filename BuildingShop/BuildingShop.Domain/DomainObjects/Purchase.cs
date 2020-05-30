using System;

namespace BuildingShop.Domain.DomainObjects
{
    public class Purchase : BaseEntity
    {
        public DateTime Date { get; set; }

        public int Amount { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }
    }
}
