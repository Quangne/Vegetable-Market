using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MarketVegetables.Categories
{
    public class CreateUpdateCategoryDto
    {
        public int CategryId { get; set; }
        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }
    }
}
