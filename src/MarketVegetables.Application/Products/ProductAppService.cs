﻿using MarketVegetables.Categories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace MarketVegetables.Products
{
    public class ProductAppService :
        CrudAppService<
            Product,
            ProductDto,
            int,
            PagedAndSortedResultRequestDto,
            CreateUpdateProductDto,
            IProductAppService>
    {
        public ProductAppService(IRepository<Product, int> repository) : base(repository)
        {

        }
    }
}
