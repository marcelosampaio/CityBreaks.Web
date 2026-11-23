using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace CityBreaks.Web.Models;

public class Property
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public decimal PricePerNight { get; set; }
    public int CityId { get; set; }
    public DateTime? DeletedAt { get; set; }

    [ValidateNever]
    public City City { get; set; } = null!;
}