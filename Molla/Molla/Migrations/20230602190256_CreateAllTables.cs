using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Molla.Migrations
{
    public partial class CreateAllTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Discounts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Percent = table.Column<byte>(type: "tinyint", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sizes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sizes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SliderInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SliderInfos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sliders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sliders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SellCount = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    DiscountId = table.Column<int>(type: "int", nullable: true),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    SizeId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Discounts_DiscountId",
                        column: x => x.DiscountId,
                        principalTable: "Discounts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Sizes_SizeId",
                        column: x => x.SizeId,
                        principalTable: "Sizes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductImages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsMain = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    SoftDelete = table.Column<bool>(type: "bit", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductImages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductImages_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "CreateDate", "Description", "Image", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(4889), "Phasellus hendrerit. Pellentesque aliquet nibh nec urna. In nisi neque, aliquet vel, dapibus id, mattis vel, nisi. Sed pretium, ligula sollicitudin laoreet viverra, tortor libero sodales leo, eget blandit nunc tortor eu nibh ...", "blog-bigP-1.jpeg", "Sed adipiscing ornare", false },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(4902), "Phasellus hendrerit. Pellentesque aliquet nibh nec urna. In nisi neque, aliquet vel, dapibus id, mattis vel, nisi. Sed pretium, ligula sollicitudin laoreet viverra, tortor libero sodales leo, eget blandit nunc tortor eu nibh ...", "blog-bigP-2.jpeg", "Sed adipiscing ornare", false },
                    { 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(4903), "Phasellus hendrerit. Pellentesque aliquet nibh nec urna. In nisi neque, aliquet vel, dapibus id, mattis vel, nisi. Sed pretium, ligula sollicitudin laoreet viverra, tortor libero sodales leo, eget blandit nunc tortor eu nibh ...", "blog-bigP-3.jpeg", "Sed adipiscing ornare", false },
                    { 4, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(4903), "Phasellus hendrerit. Pellentesque aliquet nibh nec urna. In nisi neque, aliquet vel, dapibus id, mattis vel, nisi. Sed pretium, ligula sollicitudin laoreet viverra, tortor libero sodales leo, eget blandit nunc tortor eu nibh ...", "blog-bigP-4.jpeg", "Sed adipiscing ornare", false },
                    { 5, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(4904), "Phasellus hendrerit. Pellentesque aliquet nibh nec urna. In nisi neque, aliquet vel, dapibus id, mattis vel, nisi. Sed pretium, ligula sollicitudin laoreet viverra, tortor libero sodales leo, eget blandit nunc tortor eu nibh ...", "blog-bigP-5.jpeg", "Sed adipiscing ornare", false }
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "CreateDate", "Icon", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(4998), "brand1.png", false },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(4999), "brand2.png", false },
                    { 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5000), "brand3.png", false },
                    { 4, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5000), "brand4.png", false },
                    { 5, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5001), "brand5.png", false },
                    { 6, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5001), "brand6.png", false },
                    { 7, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5002), "brand7.png", false },
                    { 8, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5002), "brand8.png", false },
                    { 9, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5003), "brand9.png", false }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreateDate", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5016), "Electronics", false },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5017), "Gift Ideas", false },
                    { 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5017), "Beds", false },
                    { 4, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5018), "Lighting", false },
                    { 5, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5018), "Sofas & Sleeper sofas", false },
                    { 6, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5019), "Storage", false },
                    { 7, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5019), "Armchairs & Chaises", false },
                    { 8, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5020), "Decoration", false },
                    { 9, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5020), "Kitchen Cabinets", false },
                    { 10, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5021), "Coffee & Tables", false },
                    { 11, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5021), "Outdoor Furniture", false }
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "CreateDate", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5030), "Blue", false },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5031), "Black", false },
                    { 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5031), "White", false },
                    { 4, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5032), "Red", false },
                    { 5, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5032), "Yellow", false }
                });

            migrationBuilder.InsertData(
                table: "Discounts",
                columns: new[] { "Id", "CreateDate", "Name", "Percent", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5041), "Black Friday", (byte)70, false },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5042), "Spring Discount", (byte)50, false },
                    { 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5042), "No Discount", (byte)0, false }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "CreateDate", "Description", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5154), "orders $50 or more", "Free Shipping", false },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5155), "within 30 days", "Free Returns", false },
                    { 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5155), "When you sign up", "Get 20% Off 1 Item", false },
                    { 4, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5156), "24/7 amazing services", "We Support", false }
                });

            migrationBuilder.InsertData(
                table: "Sizes",
                columns: new[] { "Id", "CreateDate", "Name", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5050), "Small", false },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5051), "Medium", false },
                    { 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5052), "Large", false }
                });

            migrationBuilder.InsertData(
                table: "SliderInfos",
                columns: new[] { "Id", "CreateDate", "Description", "SoftDelete", "Title" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5176), "Airpods Earphones", false, "Daily Deals" },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5177), "Echo Dot 3rd Gen", false, "Deals and Promotions" }
                });

            migrationBuilder.InsertData(
                table: "Sliders",
                columns: new[] { "Id", "CreateDate", "Image", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5167), "slider-1.jpeg", false },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5168), "slider-2.jpeg", false }
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreateDate", "Image", "Name", "Position", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5185), "member-1.jpg", "Samanta Grey", "Founder & CEO", false },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5186), "member-3.jpg", "Janet Joy", "Product Manager", false },
                    { 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5187), "member-2.jpg", "Bruce Sutton", "Sales & Marketing Manager", false }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "ColorId", "CreateDate", "Description", "DiscountId", "Name", "Price", "Rating", "SellCount", "SizeId", "SoftDelete" },
                values: new object[,]
                {
                    { 1, 1, 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5059), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "Apple MacBook Pro 14 MPHK3RU/A Silver", 7489m, 5, 20000, 3, false },
                    { 2, 1, 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5062), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "iPhone 14 Pro 256 GB Deep Purple", 3149m, 3, 2500, 3, false },
                    { 3, 2, 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5064), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 2, "2E Gaming Set of wheels Clear / 2E-GWH-002-CL", 49m, 2, 100, 2, false },
                    { 4, 2, 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5065), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 1, "Gaming Floor Mat Canyon Camouflage / CND-SFM02", 79m, 1, 100, 1, false },
                    { 5, 3, 5, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5066), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "Gala Wood", 4899m, 5, 900, 3, false },
                    { 6, 3, 4, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5067), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "İmfa Viva", 2599m, 4, 800, 3, false },
                    { 7, 4, 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5090), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "Beurer SL10", 79m, 3, 2600, 3, false },
                    { 8, 4, 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5091), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 2, "Smart Solar", 79m, 2, 20, 2, false },
                    { 9, 5, 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5092), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 1, "Gala Astana", 2999m, 1, 4200, 1, false },
                    { 10, 5, 5, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5093), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "Alzzoni Paris", 2249m, 5, 2000, 3, false },
                    { 11, 6, 4, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5094), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "Tramontina Food Storage", 33m, 4, 500, 3, false },
                    { 12, 6, 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5095), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "Car Storage", 22m, 3, 6200, 3, false },
                    { 13, 7, 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5096), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 2, "CAM Scudo 166", 749m, 2, 1200, 2, false },
                    { 14, 7, 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5097), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 1, "Softaç Art", 539m, 1, 4200, 1, false },
                    { 15, 8, 5, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5098), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "Chicco", 69m, 5, 1000, 3, false },
                    { 16, 8, 4, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5099), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "Hape", 129m, 4, 2100, 3, false },
                    { 17, 9, 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5100), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "La Sommeliere ", 2199m, 3, 2300, 3, false },
                    { 18, 9, 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5102), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 2, "Pozis FH", 899m, 2, 200, 2, false },
                    { 19, 10, 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5103), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 1, "AEG KKK994500T", 7199m, 1, 240, 1, false },
                    { 20, 10, 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5104), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 2, "Philips EP2236/40", 1699m, 3, 2000, 3, false },
                    { 21, 11, 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5105), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "Karcher K5 EU", 1059m, 5, 270, 2, false },
                    { 22, 11, 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5106), "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque", 3, "Total TGT11276/3000w", 2299m, 5, 500, 1, false }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "CreateDate", "Image", "IsMain", "ProductId", "SoftDelete" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5119), "notebook.png", true, 1, false },
                    { 2, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5120), "notebook2.png", false, 1, false },
                    { 3, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5121), "phone.png", true, 1, false },
                    { 4, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5121), "phone2.png", false, 1, false },
                    { 5, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5122), "canyon2.png", true, 2, false },
                    { 6, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5122), "gift2.png", true, 2, false },
                    { 7, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5123), "beds.png", true, 3, false },
                    { 8, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5124), "beds1.png", false, 3, false },
                    { 9, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5124), "beds2.png", true, 3, false },
                    { 10, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5125), "beds3.png", false, 3, false },
                    { 11, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5126), "light.png", true, 4, false },
                    { 12, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5126), "light2.png", false, 4, false },
                    { 13, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5128), "light4.png", true, 4, false },
                    { 14, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5129), "sofa.png", true, 5, false },
                    { 15, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5130), "sofa2.png", true, 5, false },
                    { 16, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5131), "storage.png", true, 6, false },
                    { 17, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5131), "storage2.png", false, 6, false },
                    { 18, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5132), "stroge.png", true, 6, false },
                    { 19, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5132), "chair2.png", true, 7, false },
                    { 20, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5133), "chair3.png", false, 7, false },
                    { 21, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5133), "chair1.png", true, 7, false },
                    { 22, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5134), "decor.png", true, 8, false },
                    { 23, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5135), "decor2.png", false, 8, false },
                    { 24, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5135), "decor3.png", true, 8, false },
                    { 25, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5136), "decor4.png", false, 8, false },
                    { 26, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5136), "kitchen.png", true, 9, false },
                    { 27, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5137), "kitchen2.png", false, 9, false },
                    { 28, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5137), "kitchen3.png", true, 9, false },
                    { 29, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5138), "kitchen4.png", false, 9, false },
                    { 30, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5138), "coffee.png", true, 10, false },
                    { 31, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5139), "coffee2.png", true, 10, false },
                    { 32, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5140), "coffee3.png", false, 10, false },
                    { 33, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5140), "outdoor.png", true, 11, false },
                    { 34, new DateTime(2023, 6, 2, 23, 2, 56, 609, DateTimeKind.Local).AddTicks(5141), "outdoor3.png", true, 11, false }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImages",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ColorId",
                table: "Products",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_DiscountId",
                table: "Products",
                column: "DiscountId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SizeId",
                table: "Products",
                column: "SizeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "ProductImages");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "SliderInfos");

            migrationBuilder.DropTable(
                name: "Sliders");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Discounts");

            migrationBuilder.DropTable(
                name: "Sizes");
        }
    }
}
