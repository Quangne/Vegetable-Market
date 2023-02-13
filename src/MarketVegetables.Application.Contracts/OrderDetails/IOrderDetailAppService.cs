using MarketVegetables.Categories;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace MarketVegetables.OrderDetails
{
    public interface IOrderDetailAppService :
        ICrudAppService<
            OrderDetailDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateOrderDetailDto>
    {
    }
}
