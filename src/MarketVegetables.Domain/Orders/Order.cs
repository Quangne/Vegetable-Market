using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MarketVegetables.Orders
{
    public class Order : AuditedAggregateRoot<int>
    {
        public int OrderId { get; set; }
        public Guid UserId { get; set; }
        public DateTime Created { get; set; }
        public decimal TotalBill { get; set; }
        public DateTime OrderDeliverDate { get; set; }
        public OrderTypes MyProperty { get; set; }
    }
}
