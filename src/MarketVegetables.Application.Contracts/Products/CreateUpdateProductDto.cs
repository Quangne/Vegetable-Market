using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MarketVegetables.Products
{
    public class CreateUpdateProductDto
    {
        public int ProductId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public int UnitId { get; set; }
        [Required]
        [MaxLength(200)]
        public string ProductName { get; set; }
        [Required]
        public decimal ProductPrice { get; set; }
        public string Producer { get; set; }
        public string ProductDescription { get; set; }
        [Required]
        public float ProductAmount { get; set; }
    }
}
