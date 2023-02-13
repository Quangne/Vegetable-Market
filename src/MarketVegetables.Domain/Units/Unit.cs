using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MarketVegetables.Units
{
    public class Unit : AuditedAggregateRoot<int>
    {
        public int UnitId { get; set; }
        public string UnitName { get; set; }
    }
}
