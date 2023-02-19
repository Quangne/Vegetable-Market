using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MarketVegetables.Units
{
    public class CreateUpdateUnitDto: CreationAuditedEntityDto<int>
    {
        public int UnitId { get; set; }
        [Required]
        [StringLength(50)]
        public string UnitName { get; set; }
    }
}
