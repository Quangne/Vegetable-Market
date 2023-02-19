using AutoMapper;
using MarketVegetables.Categories;
using MarketVegetables.Units;
using MarketVegetables.Web.Pages.Categories;
using MarketVegetables.Web.Pages.Units;

namespace MarketVegetables.Web;

public class MarketVegetablesWebAutoMapperProfile : Profile
{
    public MarketVegetablesWebAutoMapperProfile()
    {
        CreateMap<CategoryDto, CreateUpdateCategoryDto>();
        CreateMap<CreateCategoryViewModel, CreateUpdateCategoryDto>();
        CreateMap<CategoryDto, CreateCategoryViewModel>();

        CreateMap<UnitDto, CreateUnitViewModel>();
        CreateMap<UnitDto, CreateUpdateUnitDto>();
        CreateMap<CreateUnitViewModel, CreateUpdateUnitDto>();
    }
}
