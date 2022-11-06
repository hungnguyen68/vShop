using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using vShop.Data.Configuration;
using vShop.Data.Entities;

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
        }

        #region DBSet
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Product> Products { get; set; }
        #endregion

    }
}
