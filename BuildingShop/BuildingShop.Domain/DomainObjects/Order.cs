using System;

namespace BuildingShop.Domain.DomainObjects
{
    public class Order : BaseEntity
    {
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }

        public int StartingAmount { get; set; }
        public int EndAmount { get; set; }

        public int TotalIncome { get; set; }
        public int TotalOutcome { get; set; }

        public int DaysWithoutProduct { get; set; }
        public decimal AverageSalesPerDay { get; set; }
        public int MinSalePerDay { get; set; }
        public int FinalNumber { get; set; } 
    }
}
