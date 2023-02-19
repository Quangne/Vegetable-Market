using MarketVegetables.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MarketVegetables.OrderDetails
{
    public class OrderDetailAppService :
        CrudAppService<
            OrderDetail,
            OrderDetailDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateOrderDetailDto>,
            IOrderDetailAppService
    {
        public OrderDetailAppService(IRepository<OrderDetail, int> repository) : base(repository)
        {

        }
    }
}
