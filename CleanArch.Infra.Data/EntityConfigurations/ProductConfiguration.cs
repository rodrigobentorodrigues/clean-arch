using CleanArch.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CleanArch.Infra.Data.EntityConfigurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property((product) => product.Name).HasMaxLength(100).IsRequired();
            builder.Property((product) => product.Description).HasMaxLength(200).IsRequired();
            builder.Property((product) => product.Price).HasPrecision(10, 2);

            builder.HasData(
                new Product
                {
                    Id = 1,
                    Name = "Caderno",
                    Description = "Caderno espiral 100 folhas",
                    Price = 9.45m
                },
                new Product
                {
                    Id = 2,
                    Name = "Borracha",
                    Description = "Borracha branca pequena",
                    Price = 3.75m
                },
                new Product
                {
                    Id = 3,
                    Name = "Estojo",
                    Description = "Estojo de plástico pequeno",
                    Price = 5.25m
                });
        }
    }
}
