using MarketVegetables.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MarketVegetables.Orders
{
    public class OrderAppService :
        CrudAppService<
            Order,
            OrderDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateOrderDto>,
            IOrderAppService
    {
        public OrderAppService(IRepository<Order, int> repository) : base(repository)
        {

        }
    }
}
