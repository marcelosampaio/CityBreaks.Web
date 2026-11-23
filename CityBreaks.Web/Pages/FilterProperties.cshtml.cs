using CityBreaks.Web.Models;
using CityBreaks.Web.Services;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CityBreaks.Web.Pages;

public class FilterPropertiesModel : PageModel
{
    private readonly IPropertyService _propertyService;

    public FilterPropertiesModel(IPropertyService propertyService)
    {
        _propertyService = propertyService;
    }

    public decimal? MinPrice { get; set; }

    public decimal? MaxPrice { get; set; }

    public string CityName { get; set; } = string.Empty;

    public string PropertyName { get; set; } = string.Empty;

    public List<Property> Properties { get; set; } = new();

    public async Task OnGetAsync(
        decimal? minPrice,
        decimal? maxPrice,
        string cityName,
        string propertyName)
    {
        MinPrice = minPrice;
        MaxPrice = maxPrice;
        CityName = cityName ?? string.Empty;
        PropertyName = propertyName ?? string.Empty;

        Properties = await _propertyService.GetFilteredAsync(
            MinPrice,
            MaxPrice,
            CityName,
            PropertyName
        );
    }
}