using System;

namespace BuildingShop.Domain.DomainObjects
{
    public class ProductAmountTracker : BaseEntity
    {
        public int Amount { get; set; }

        public DateTime Date { get; set; }
    }
}
