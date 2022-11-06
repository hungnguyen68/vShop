using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using vShop.Data.Entities;

namespace vShop.Data.Extension
{
    public static class ModelBuilderExtension
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category() { Id = new Guid("cd2a2b8d-2531-41d8-9383-2c1ed5277e6b"), Name = "Điện thoại", Desc ="Các mẫu điện thoại", IsShownOnHome = true, SortOrder = 0 },
                new Category() { Id = new Guid("ab516751-779e-4eba-9722-0610dbd94115"), Name = "Ti vi", Desc ="Các mẫu tivi", IsShownOnHome = true, SortOrder = 1 },
                new Category() { Id = new Guid("47c0d505-234c-4f80-805b-284d6ac2c9b7"), Name = "Tủ lạnh", Desc ="Các mẫu tủ lạnh", IsShownOnHome = true, SortOrder = 2 }

            );

            modelBuilder.Entity<Product>().HasData(

                #region Điện thoại: cd2a2b8d-2531-41d8-9383-2c1ed5277e6b
                new Product() { Id = new Guid("261287a7-aab9-497a-ad90-2d36154c4a15"),
                    Name = "Điện thoại Samsung Galaxy S22 Ultra 5G 128GB",
                    CategoryId = new Guid("cd2a2b8d-2531-41d8-9383-2c1ed5277e6b"),
                    Desc = "Được cho ra mắt vào tháng 02/2022, Samsung Galaxy S22 Ultra 5G gây sốt trong cộng đồng công nghệ bởi hiệu năng mạnh mẽ, thiết kế đẳng cấp sang trọng cùng nhiều tiện ích do bút S Pen mang lại.",
                    OriginalPrice = 30990000,
                    Price = 25990000,
                    Image = "https://cdn.tgdd.vn/Products/Images/42/235838/samsung-galaxy-s22-ultra-1-1.jpg",
                },

                new Product()
                {
                    Id = new Guid("dd250e6e-7c28-4eff-91d5-646ecde41a86"),
                    Name = "Điện thoại iPhone 11 64GB",
                    CategoryId = new Guid("cd2a2b8d-2531-41d8-9383-2c1ed5277e6b"),
                    Desc = "Sau chiếc điện thoại iPhone Xr, Apple tiếp tục ra mắt siêu phẩm 2019 mang tên iPhone 11 64GB - một smartphone được nâng cấp toàn diện từ thiết kế cao cấp, vi xử lý hiệu năng mạnh mẽ đến hệ thống camera chất lượng cùng thời lượng pin vượt trội.",
                    OriginalPrice = 14990000,
                    Price = 11990000,
                    Image = "https://cdn.tgdd.vn/Products/Images/42/153856/Slider/vi-vn-iphone-11-tinhnang.jpg",
                },
            #endregion

                #region Tivi: ab516751-779e-4eba-9722-0610dbd94115
                new Product()
                {
                    Id = new Guid("cb7b527a-8bd9-409b-800e-77a39300fe00"),
                    Name = "Smart Tivi Samsung 4K Crystal UHD 50 inch UA50AU8100",
                    CategoryId = new Guid("ab516751-779e-4eba-9722-0610dbd94115"),
                    Desc = "Hòa mình vào thế giới giải trí với màn hình không viền 3 cạnh ấn tượng",
                    OriginalPrice = 17400000,
                    Price = 12150000,
                    Image = "https://cdn.tgdd.vn/Products/Images/1942/235791/led-4k-samsung-ua50au8100-1.jpg",
                },

                new Product()
                {
                    Id = new Guid("d8e6eb96-7417-4608-b9d9-055da2fba317"),
                    Name = "Google Tivi Sony 4K 55 inch KD - 55X80K",
                    CategoryId = new Guid("ab516751-779e-4eba-9722-0610dbd94115"),
                    Desc = "Google Tivi Sony 4K 55 inch KD-55X80K cho chất lượng hình ảnh sắc nét, độ bão hòa cao, hình ảnh mượt mà, hạn chế nhòe hình nhờ công nghệ nâng cấp chuẩn hình ảnh 4K X-Reality PRO. Công nghệ loa bất đối xứng X-Balanced cho chất lượng âm thanh cao dù thiết kế tivi mỏng.",
                    OriginalPrice = 19900000,
                    Price = 18360000,
                    Image = "https://cdn.tgdd.vn/Products/Images/1942/274761/Slider/android-sony-4k-55-inch-kd-55x80k637844183249225344.jpg",
                },
                #endregion

                #region Tủ lạnh: 47c0d505-234c-4f80-805b-284d6ac2c9b7
                new Product()
                {
                    Id = new Guid("d264f04b-4b8d-42ba-a753-fd522e99ee46"),
                    Name = "Tủ lạnh Samsung Inverter 319 lít RT32K5932BY/SV",
                    CategoryId = new Guid("47c0d505-234c-4f80-805b-284d6ac2c9b7"),
                    Desc = "Dù sở hữu thiết ngăn đá trên truyền thống, tủ lạnh Samsung Inverter 319 lít RT32K5932BY/SV vẫn sẽ mang đến cho không gian bếp nhà bạn một làn gió mới nhờ chất liệu cửa tủ mới lạ. Cửa tủ lạnh được làm từ kim loại phủ sơn bóng giả gương sang trọng, giúp làm bật lên không gian bếp của bạn.",
                    OriginalPrice = 10820000,
                    Price = 15090000,
                    Image = "https://cdn.tgdd.vn/Products/Images/1943/226358/Slider/samsung-rt32k5932by-sv-140821-0852180.png",
                },

                new Product()
                {
                    Id = new Guid("321189e5-72d4-43f7-b672-603a8aeadd3a"),
                    Name = "Tủ lạnh LG Inverter 649 Lít GR-B257JDS",
                    CategoryId = new Guid("47c0d505-234c-4f80-805b-284d6ac2c9b7"),
                    Desc = "Tủ lạnh LG Inverter 649 Lít GR-B257JDS là mẫu tủ lạnh side by side được trang bị động cơ Linear Inverter giúp tiết kiệm điện năng. Tích hợp khả năng làm lạnh đa chiều giúp hơi lạnh lan toả đều đến các ngăn.",
                    OriginalPrice = 23490000,
                    Price = 17990000,
                    Image = "https://cdn.tgdd.vn/Products/Images/1942/274761/Slider/android-sony-4k-55-inch-kd-55x80k637844183249225344.jpg"
                }
                #endregion
            );
            
        }
    }
}
