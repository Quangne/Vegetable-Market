using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MarketVegetables.Products
{
    public class ProductDto : AuditedEntityDto<int>
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
