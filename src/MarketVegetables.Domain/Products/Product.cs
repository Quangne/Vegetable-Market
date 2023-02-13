using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MarketVegetables.Products
{
    public class Product : AuditedAggregateRoot<int>
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int UnitId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string Producer { get; set; }
        public string ProductDescription { get; set; }
        public float ProductAmount { get; set; }

    }
}
