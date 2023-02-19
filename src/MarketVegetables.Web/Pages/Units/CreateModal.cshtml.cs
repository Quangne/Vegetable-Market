using MarketVegetables.Categories;
using MarketVegetables.Units;
using MarketVegetables.Web.Pages.Categories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace MarketVegetables.Web.Pages.Units
{
    public class CreateModalModel : MarketVegetablesPageModel
    {
        [BindProperty]
        public CreateUnitViewModel Unit { get; set; }

        private readonly IUnitAppService _unitAppService;
        public CreateModalModel(IUnitAppService unitAppService)
        {
            _unitAppService = unitAppService;
        }
        public void OnGet()
        {
            Unit = new CreateUnitViewModel();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            var dto = ObjectMapper.Map<CreateUnitViewModel, CreateUpdateUnitDto>(Unit);
            await _unitAppService.CreateAsync(dto);
            return NoContent();
        }
    }
    public class CreateUnitViewModel
    {
        public int Id { get; set; }
        public int UnitId { get; set; }
        [Required]
        [StringLength(200)]
        public string UnitName { get; set; }

    }
}
