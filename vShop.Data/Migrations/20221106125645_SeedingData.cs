using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace vShop.Data.Migrations
{
    public partial class SeedingData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Desc", "IsShownOnHome", "Name", "SortOrder" },
                values: new object[] { new Guid("47c0d505-234c-4f80-805b-284d6ac2c9b7"), "Các mẫu tủ lạnh", true, "Tủ lạnh", 2 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Desc", "IsShownOnHome", "Name", "SortOrder" },
                values: new object[] { new Guid("ab516751-779e-4eba-9722-0610dbd94115"), "Các mẫu tivi", true, "Ti vi", 1 });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Desc", "IsShownOnHome", "Name", "SortOrder" },
                values: new object[] { new Guid("cd2a2b8d-2531-41d8-9383-2c1ed5277e6b"), "Các mẫu điện thoại", true, "Điện thoại", 0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Desc", "Image", "Name", "OriginalPrice", "Price" },
                values: new object[,]
                {
                    { new Guid("261287a7-aab9-497a-ad90-2d36154c4a15"), new Guid("cd2a2b8d-2531-41d8-9383-2c1ed5277e6b"), "Được cho ra mắt vào tháng 02/2022, Samsung Galaxy S22 Ultra 5G gây sốt trong cộng đồng công nghệ bởi hiệu năng mạnh mẽ, thiết kế đẳng cấp sang trọng cùng nhiều tiện ích do bút S Pen mang lại.", "https://cdn.tgdd.vn/Products/Images/42/235838/samsung-galaxy-s22-ultra-1-1.jpg", "Điện thoại Samsung Galaxy S22 Ultra 5G 128GB", 30990000m, 25990000m },
                    { new Guid("321189e5-72d4-43f7-b672-603a8aeadd3a"), new Guid("47c0d505-234c-4f80-805b-284d6ac2c9b7"), "Tủ lạnh LG Inverter 649 Lít GR-B257JDS là mẫu tủ lạnh side by side được trang bị động cơ Linear Inverter giúp tiết kiệm điện năng. Tích hợp khả năng làm lạnh đa chiều giúp hơi lạnh lan toả đều đến các ngăn.", "https://cdn.tgdd.vn/Products/Images/1942/274761/Slider/android-sony-4k-55-inch-kd-55x80k637844183249225344.jpg", "Tủ lạnh LG Inverter 649 Lít GR-B257JDS", 23490000m, 17990000m },
                    { new Guid("cb7b527a-8bd9-409b-800e-77a39300fe00"), new Guid("ab516751-779e-4eba-9722-0610dbd94115"), "Hòa mình vào thế giới giải trí với màn hình không viền 3 cạnh ấn tượng", "https://cdn.tgdd.vn/Products/Images/1942/235791/led-4k-samsung-ua50au8100-1.jpg", "Smart Tivi Samsung 4K Crystal UHD 50 inch UA50AU8100", 17400000m, 12150000m },
                    { new Guid("d264f04b-4b8d-42ba-a753-fd522e99ee46"), new Guid("47c0d505-234c-4f80-805b-284d6ac2c9b7"), "Dù sở hữu thiết ngăn đá trên truyền thống, tủ lạnh Samsung Inverter 319 lít RT32K5932BY/SV vẫn sẽ mang đến cho không gian bếp nhà bạn một làn gió mới nhờ chất liệu cửa tủ mới lạ. Cửa tủ lạnh được làm từ kim loại phủ sơn bóng giả gương sang trọng, giúp làm bật lên không gian bếp của bạn.", "https://cdn.tgdd.vn/Products/Images/1943/226358/Slider/samsung-rt32k5932by-sv-140821-0852180.png", "Tủ lạnh Samsung Inverter 319 lít RT32K5932BY/SV", 10820000m, 15090000m },
                    { new Guid("d8e6eb96-7417-4608-b9d9-055da2fba317"), new Guid("ab516751-779e-4eba-9722-0610dbd94115"), "Google Tivi Sony 4K 55 inch KD-55X80K cho chất lượng hình ảnh sắc nét, độ bão hòa cao, hình ảnh mượt mà, hạn chế nhòe hình nhờ công nghệ nâng cấp chuẩn hình ảnh 4K X-Reality PRO. Công nghệ loa bất đối xứng X-Balanced cho chất lượng âm thanh cao dù thiết kế tivi mỏng.", "https://cdn.tgdd.vn/Products/Images/1942/274761/Slider/android-sony-4k-55-inch-kd-55x80k637844183249225344.jpg", "Google Tivi Sony 4K 55 inch KD - 55X80K", 19900000m, 18360000m },
                    { new Guid("dd250e6e-7c28-4eff-91d5-646ecde41a86"), new Guid("cd2a2b8d-2531-41d8-9383-2c1ed5277e6b"), "Sau chiếc điện thoại iPhone Xr, Apple tiếp tục ra mắt siêu phẩm 2019 mang tên iPhone 11 64GB - một smartphone được nâng cấp toàn diện từ thiết kế cao cấp, vi xử lý hiệu năng mạnh mẽ đến hệ thống camera chất lượng cùng thời lượng pin vượt trội.", "https://cdn.tgdd.vn/Products/Images/42/153856/Slider/vi-vn-iphone-11-tinhnang.jpg", "Điện thoại iPhone 11 64GB", 14990000m, 11990000m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("261287a7-aab9-497a-ad90-2d36154c4a15"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("321189e5-72d4-43f7-b672-603a8aeadd3a"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("cb7b527a-8bd9-409b-800e-77a39300fe00"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d264f04b-4b8d-42ba-a753-fd522e99ee46"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("d8e6eb96-7417-4608-b9d9-055da2fba317"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("dd250e6e-7c28-4eff-91d5-646ecde41a86"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("47c0d505-234c-4f80-805b-284d6ac2c9b7"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("ab516751-779e-4eba-9722-0610dbd94115"));

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: new Guid("cd2a2b8d-2531-41d8-9383-2c1ed5277e6b"));
        }
    }
}
