using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vShop.Data.Configuration;
using vShop.Data.Entities;
using vShop.Data.Extension;

namespace vShop.Data.EF
{
    public class vShopDbContext : DbContext
    {
        public vShopDbContext(DbContextOptions options) : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());

            //Data seeding
            modelBuilder.Seed();
        }

        #region DBSet
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products { get; set; }
        #endregion

    }
}
