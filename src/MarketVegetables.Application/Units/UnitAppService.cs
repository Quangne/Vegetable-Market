using MarketVegetables.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MarketVegetables.Units
{
    public class UnitAppService :
        CrudAppService<
            Unit,
            UnitDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateUnitDto>,
        IUnitAppService
    {
        public UnitAppService(IRepository<Unit, int> repository) : base(repository)
        {

        }
    }
}
