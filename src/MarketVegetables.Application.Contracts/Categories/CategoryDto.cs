using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace MarketVegetables.Categories
{
    public class CategoryDto : AuditedEntityDto<int>
    {
        public int CategryId { get; set; }
        public string CategoryName { get; set; }
        public string ImageUrl { get; set; }
    }
}
