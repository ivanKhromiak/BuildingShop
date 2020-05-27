using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingShop.Domain.DomainObjects
{
    public class ShopCartItem : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public string ShopCartId { get; set; }
    }
}
