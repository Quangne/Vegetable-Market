using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MarketVegetables.Orders
{
    public class OrderDto : AuditedEntityDto<int>
    {
        public int OrderId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Created { get; set; }
        public decimal TotalBill { get; set; }
        public DateTime OrderDeliverDate { get; set; }
        public OrderTypes MyProperty { get; set; }
    }
}
