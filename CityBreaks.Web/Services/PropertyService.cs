using CityBreaks.Web.Data;
using Microsoft.EntityFrameworkCore;

namespace CityBreaks.Web.Services;

public class PropertyService : IPropertyService
{
    private readonly CityBreaksContext _context;

    public PropertyService(CityBreaksContext context)
    {
        _context = context;
    }

    public async Task DeleteAsync(int id)
    {
        var property = await _context.Properties.FindAsync(id);

        if (property == null || property.DeletedAt != null)
        {
            return;
        }

        property.DeletedAt = DateTime.UtcNow;

        await _context.SaveChangesAsync();
    }
}