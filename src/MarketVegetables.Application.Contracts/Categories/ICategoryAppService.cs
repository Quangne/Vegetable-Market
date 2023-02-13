using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketVegetables.Categories
{
    public interface ICategoryAppService : 
        ICrudAppService<
            CategoryDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateCategoryDto>
    {
    }
}
