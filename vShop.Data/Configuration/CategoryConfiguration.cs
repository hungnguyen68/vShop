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
    public class CategoryConfiguration: IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            
            builder.HasKey(o => o.Id);

            builder.Property(t => t.Name).HasMaxLength(250)
                    .IsRequired();

            builder.Property(t => t.Desc).HasMaxLength(400);

            builder.Property(t => t.IsShownOnHome).HasDefaultValue(Status.Active);

            builder.Property(t => t.Status).HasDefaultValue(Status.Active);

            builder.HasMany(t => t.Products).WithOne(t => t.Category);
        }
    }
}
