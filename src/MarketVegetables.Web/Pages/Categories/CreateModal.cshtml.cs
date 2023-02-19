using MarketVegetables.Categories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;
using Volo.Abp.AspNetCore.Mvc.UI.Bootstrap.TagHelpers.Form;

namespace MarketVegetables.Web.Pages.Categories
{
    public class CreateModalModel : MarketVegetablesPageModel
    {
        [BindProperty]
        public CreateCategoryViewModel Category { get; set; }

        private readonly ICategoryAppService _categoryAppService;
        public CreateModalModel(ICategoryAppService categoryAppService)
        {
            _categoryAppService= categoryAppService;
        }
        public void OnGet()
        {
            Category = new CreateCategoryViewModel();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateCategoryViewModel, CreateUpdateCategoryDto>(Category);
            await _categoryAppService.CreateAsync(dto);
            return NoContent();
        }
    }
    public class CreateCategoryViewModel
    {
        public int Id { get; set; }
        public int CategryId { get; set; }
        [Required]
        [StringLength(200)]
        public string CategoryName { get; set; }

    }
}
