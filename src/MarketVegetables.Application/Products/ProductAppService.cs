using MarketVegetables.Base;
using MarketVegetables.Categories;
using MarketVegetables.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace MarketVegetables.Products
{
    public class ProductAppService :
        CrudAppService<
            Product,
            ProductDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateProductDto>,
            IProductAppService
    {
        IRepository<Category, int> CateGoryRepository;
        IRepository<Unit, int> UnitRepository;
        public ProductAppService(
            IRepository<Product, int> repository,
            IRepository<Category, int> categoryAppService,
            IRepository<Unit, int> unitAppService) : base(repository)
        {
            this.CateGoryRepository = categoryAppService;
            this.UnitRepository = unitAppService;
        }

        public async Task<ResultTableBase<List<ProductDetailsDto>>> GetProductDetails()
        {
            var products = await this.Repository.GetQueryableAsync();
            var categories = await CateGoryRepository.GetQueryableAsync();
            var units = await UnitRepository.GetQueryableAsync();
            var result = new ResultTableBase<List<ProductDetailsDto>>();
            var productQuerys = from p in products
                          join c in categories on p.CategoryId equals c.CategryId
                          join u in units on p.UnitId equals u.UnitId
                          select new ProductDetailsDto() { ProductDto = ObjectMapper.Map<Product,
                          ProductDto>(p),CategoryDto = ObjectMapper.Map<Category,CategoryDto>(c), 
                          UnitDto = ObjectMapper.Map<Unit,UnitDto>(u)};
            var exQuery = productQuerys.ToList();
                        result.Items = exQuery;
            result.TotalCount = exQuery.Count;
            return result;
        }
    }
}
