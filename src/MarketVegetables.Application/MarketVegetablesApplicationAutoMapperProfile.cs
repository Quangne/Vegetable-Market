using AutoMapper;
using MarketVegetables.Categories;
using MarketVegetables.OrderDetails;
using MarketVegetables.Orders;
using MarketVegetables.Products;
using MarketVegetables.Units;

namespace MarketVegetables;

public class MarketVegetablesApplicationAutoMapperProfile : Profile
{
    public MarketVegetablesApplicationAutoMapperProfile()
    {
        CreateMap<Category, CategoryDto>();
        CreateMap<CreateUpdateCategoryDto, Category>();

        CreateMap<Unit, UnitDto>();
        CreateMap<CreateUpdateUnitDto, Unit>();

        CreateMap<Product, UnitDto>();
        CreateMap<CreateUpdateProductDto, Product>();

        CreateMap<Order, OrderDto>();
        CreateMap<CreateUpdateOrderDto, Order>();

        CreateMap<OrderDetail, OrderDetailDto>();
        CreateMap<CreateUpdateOrderDetailDto, OrderDetail>();
    }
}
