using CityBreaks.Web.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CityBreaks.Web.Data.Configurations;

public class PropertyConfiguration : IEntityTypeConfiguration<Property>
{
    public void Configure(EntityTypeBuilder<Property> builder)
    {
        builder.Property(p => p.Name)
            .HasMaxLength(100)
            .HasColumnName("InterestPoint");

        builder.HasData(
            new Property
            {
                Id = 1,
                Name = "Hotel Brasília Central",
                PricePerNight = 350.00m,
                CityId = 1
            },
            new Property
            {
                Id = 2,
                Name = "Copacabana Palace",
                PricePerNight = 1200.00m,
                CityId = 2
            },
            new Property
            {
                Id = 3,
                Name = "Hotel Avenida Palace",
                PricePerNight = 650.00m,
                CityId = 3
            },
            new Property
            {
                Id = 4,
                Name = "PortoBay Flores",
                PricePerNight = 580.00m,
                CityId = 4
            },
            new Property
            {
                Id = 5,
                Name = "Hôtel des Arts",
                PricePerNight = 750.00m,
                CityId = 5
            },
            new Property
            {
                Id = 6,
                Name = "Hôtel de Lyon",
                PricePerNight = 420.00m,
                CityId = 6
            },
            new Property
            {
                Id = 7,
                Name = "Pousada Vila Planalto",
                PricePerNight = 280.00m,
                CityId = 1
            }
        );
    }
}