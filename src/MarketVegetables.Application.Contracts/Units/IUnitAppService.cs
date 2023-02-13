using MarketVegetables.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketVegetables.Units
{
    public interface IUnitAppService : ICrudAppService<UnitDto, int, PagedAndSortedResultRequestDto, CreateUpdateUnitDto>
    {
    }
}
