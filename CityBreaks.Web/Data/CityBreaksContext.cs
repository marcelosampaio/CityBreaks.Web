using Microsoft.EntityFrameworkCore;
using CityBreaks.Web.Models;
using CityBreaks.Web.Data.Configurations;

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
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new CountryConfiguration());
        modelBuilder.ApplyConfiguration(new CityConfiguration());
        modelBuilder.ApplyConfiguration(new PropertyConfiguration());
    }
}