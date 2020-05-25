using System;
using System.Collections.Generic;
using System.Text;

namespace BuildingShop.Domain.DomainObjects
{
    public class ShopCart : BaseEntity
    {
        public string SessionId { get; set; }

        public List<ShopCartItem> ShopCartItems { get; set; }
    }
}
