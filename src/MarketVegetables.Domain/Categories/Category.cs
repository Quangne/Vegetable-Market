using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace MarketVegetables.Categories
{
    public class Category : AuditedAggregateRoot<int>
    {
        public int CategryId { get; set; }
        public string CategoryName { get; set; }
    }
}
