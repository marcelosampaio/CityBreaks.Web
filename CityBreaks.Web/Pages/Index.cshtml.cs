using CityBreaks.Web.Models;
using CityBreaks.Web.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Web.Pages;

public class IndexModel : PageModel
{
    private readonly ICityService _cityService;
    private readonly IPropertyService _propertyService;

    public IndexModel(
        ICityService cityService,
        IPropertyService propertyService)
    {
        _cityService = cityService;
        _propertyService = propertyService;
    }

    public List<City> Cities { get; set; } = new();

    public async Task OnGetAsync()
    {
        Cities = await _cityService.GetAllAsync();
    }

    public async Task<IActionResult> OnPostDeleteAsync(int id)
    {
        await _propertyService.DeleteAsync(id);

        return RedirectToPage("/Index");
    }
}