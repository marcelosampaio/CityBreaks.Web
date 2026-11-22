using Microsoft.EntityFrameworkCore;
using CityBreaks.Web.Models;

namespace CityBreaks.Web.Data;

public class CityBreaksContext : DbContext
{
    public CityBreaksContext(DbContextOptions<CityBreaksContext> options)
        : base(options)
    {
    }

    public DbSet<Country> Countries { get; set; } = null!;
    public DbSet<City> Cities { get; set; } = null!;
    public DbSet<Property> Properties { get; set; } = null!;
}