using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vShop.Data.Entities;
using vShop.Data.Entities.Enum;

namespace vShop.Data.Configuration
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");

            builder.HasKey(t => t.Id);

            builder.Property(t => t.Name).IsRequired().HasMaxLength(250);
            
            builder.Property(t => t.Desc).HasMaxLength(400);

            builder.Property(t => t.Price).IsRequired();

            builder.Property(t => t.CategoryId).IsRequired(false);

            builder.Property(t => t.Status).HasDefaultValue(Status.Active);

            builder.HasOne(t => t.Category)
                .WithMany(t => t.Products)
                .HasForeignKey(t => t.CategoryId)
                .IsRequired(false)
                .HasConstraintName("FK_Product_Category")
                .OnDelete(DeleteBehavior.SetNull);

        }
    }
}
