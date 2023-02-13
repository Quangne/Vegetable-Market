using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MarketVegetables.OrderDetails
{
    public class OrderDetailDto : AuditedEntityDto<int>
    {
        public int OrderDetailId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public float Amount { get; set; }
    }
}
