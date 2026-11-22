using CityBreaks.Web.Data;
using CityBreaks.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Pages;

public class EditPropertyModel : PageModel
{
    private readonly CityBreaksContext _context;

    public EditPropertyModel(CityBreaksContext context)
    {
        _context = context;
    }

    public Property Property { get; set; } = null!;

    public SelectList Cities { get; set; } = null!;

    public async Task<IActionResult> OnGetAsync(int id)
    {
        var property = await _context.Properties.FindAsync(id);

        if (property == null)
        {
            return NotFound();
        }

        Property = property;

        await LoadCitiesAsync();

        return Page();
    }

    public async Task<IActionResult> OnPostAsync(int id)
    {
        var property = await _context.Properties.FindAsync(id);

        if (property == null)
        {
            return NotFound();
        }

        var updated = await TryUpdateModelAsync(
            property,
            nameof(Property),
            p => p.Name,
            p => p.PricePerNight,
            p => p.CityId
        );

        if (!updated)
        {
            Property = property;
            await LoadCitiesAsync();
            return Page();
        }

        await _context.SaveChangesAsync();

        return RedirectToPage("/Index");
    }

    private async Task LoadCitiesAsync()
    {
        var cities = await _context.Cities
            .OrderBy(c => c.Name)
            .ToListAsync();

        Cities = new SelectList(cities, "Id", "Name", Property.CityId);
    }
}