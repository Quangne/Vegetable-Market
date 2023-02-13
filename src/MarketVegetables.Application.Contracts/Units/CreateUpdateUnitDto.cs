using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MarketVegetables.Units
{
    public class CreateUpdateUnitDto
    {
        public int UnitId { get; set; }
        [Required]
        [StringLength(50)]
        public string UnitName { get; set; }
    }
}
