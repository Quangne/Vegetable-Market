using MarketVegetables.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using System;

namespace MarketVegetables.Web.Pages.Categories
{
    public class EditModalModel : MarketVegetablesPageModel
    {
        [BindProperty]
        public CreateCategoryViewModel Category { get; set; }

        private readonly ICategoryAppService _categoryAppService;
        public EditModalModel(ICategoryAppService categoryAppService)
        {
            _categoryAppService = categoryAppService;
        }
        public async Task OnGetAsync(int id)
        {
            var categoryDto = await _categoryAppService.GetAsync(id);
            Category = ObjectMapper.Map<CategoryDto, CreateCategoryViewModel>(categoryDto);
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _categoryAppService.UpdateAsync(
                Category.Id,
                ObjectMapper.Map<CreateCategoryViewModel, CreateUpdateCategoryDto>(Category)
            );

            return NoContent();
        }
    }
}
