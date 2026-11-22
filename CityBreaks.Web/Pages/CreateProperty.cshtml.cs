using CityBreaks.Web.Data;
using CityBreaks.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Pages;

public class CreatePropertyModel : PageModel
{
    private readonly CityBreaksContext _context;

    public CreatePropertyModel(CityBreaksContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Property Property { get; set; } = new();

    public SelectList Cities { get; set; } = null!;

    public async Task OnGetAsync()
    {
        await LoadCitiesAsync();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            await LoadCitiesAsync();
            return Page();
        }

        await _context.Properties.AddAsync(Property);
        await _context.SaveChangesAsync();

        return RedirectToPage("/Index");
    }

    private async Task LoadCitiesAsync()
    {
        var cities = await _context.Cities
            .OrderBy(c => c.Name)
            .ToListAsync();

        Cities = new SelectList(cities, "Id", "Name");
    }
}