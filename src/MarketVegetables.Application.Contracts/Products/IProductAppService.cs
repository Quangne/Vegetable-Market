using MarketVegetables.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketVegetables.Products
{
    public interface IProductAppService : 
        ICrudAppService<
            ProductDto,
            int, 
            PagedAndSortedResultRequestDto, 
            CreateUpdateProductDto>
    {
    }
}
