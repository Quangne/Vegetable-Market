using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MarketVegetables.Units
{
    public class UnitDto : AuditedEntityDto<int>
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
    }
}
