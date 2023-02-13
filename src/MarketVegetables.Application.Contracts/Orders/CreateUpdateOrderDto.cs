using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MarketVegetables.Orders
{
    public class CreateUpdateOrderDto
    {
        public int OrderId { get; set; }
        [Required]
        public Guid UserId { get; set; }
        [Required]
        public DateTime Created { get; set; }
        [Required]
        public decimal TotalBill { get; set; }
        [Required]
        public DateTime OrderDeliverDate { get; set; }
        public OrderTypes MyProperty { get; set; }
    }
}
