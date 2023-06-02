using Microsoft.EntityFrameworkCore;
using Molla.Models;

namespace Molla.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> option) : base(option) { }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Servic> Services { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderInfo> SliderInfos { get; set; }
        public DbSet<Team> Teams { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Brand>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Category>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Color>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Size>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Discount>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Product>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<ProductImage>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Servic>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<SliderInfo>().HasQueryFilter(m => !m.SoftDelete);
            modelBuilder.Entity<Team>().HasQueryFilter(m => !m.SoftDelete);

            modelBuilder.Entity<Blog>().HasData(
            new Blog
            {
                Id = 1,
                Name = "Sed adipiscing ornare",
                Image = "blog-bigP-1.jpeg",
                Description = "Phasellus hendrerit. Pellentesque aliquet nibh nec urna. In nisi neque, aliquet vel, dapibus id, mattis vel, nisi. Sed pretium, ligula sollicitudin laoreet viverra, tortor libero sodales leo, eget blandit nunc tortor eu nibh ..."
            },
            new Blog
            {
                Id = 2,
                Name = "Sed adipiscing ornare",
                Image = "blog-bigP-2.jpeg",
                Description = "Phasellus hendrerit. Pellentesque aliquet nibh nec urna. In nisi neque, aliquet vel, dapibus id, mattis vel, nisi. Sed pretium, ligula sollicitudin laoreet viverra, tortor libero sodales leo, eget blandit nunc tortor eu nibh ..."
            },
            new Blog
            {
                Id =3,
                Name = "Sed adipiscing ornare",
                Image = "blog-bigP-3.jpeg",
                Description = "Phasellus hendrerit. Pellentesque aliquet nibh nec urna. In nisi neque, aliquet vel, dapibus id, mattis vel, nisi. Sed pretium, ligula sollicitudin laoreet viverra, tortor libero sodales leo, eget blandit nunc tortor eu nibh ..."
            },
            new Blog
            {
                Id = 4,
                Name = "Sed adipiscing ornare",
                Image = "blog-bigP-4.jpeg",
                Description = "Phasellus hendrerit. Pellentesque aliquet nibh nec urna. In nisi neque, aliquet vel, dapibus id, mattis vel, nisi. Sed pretium, ligula sollicitudin laoreet viverra, tortor libero sodales leo, eget blandit nunc tortor eu nibh ..."
            },
            new Blog
            {
                Id = 5,
                Name = "Sed adipiscing ornare",
                Image = "blog-bigP-5.jpeg",
                Description = "Phasellus hendrerit. Pellentesque aliquet nibh nec urna. In nisi neque, aliquet vel, dapibus id, mattis vel, nisi. Sed pretium, ligula sollicitudin laoreet viverra, tortor libero sodales leo, eget blandit nunc tortor eu nibh ..."
            });

            modelBuilder.Entity<Brand>().HasData(
            new Brand
            {
                Id= 1,
                Icon = "brand1.png"
            },
            new Brand
            {
                Id = 2,
                Icon = "brand2.png"
            },
            new Brand
            {
                Id = 3,
                Icon = "brand3.png"
            },
            new Brand
            {
                Id = 4,
                Icon = "brand4.png"
            },
            new Brand
            {
                Id = 5,
                Icon = "brand5.png"
            },
            new Brand
            {
                Id = 6,
                Icon = "brand6.png"
            },
            new Brand
            {
                Id = 7,
                Icon = "brand7.png"
            },
            new Brand
            {
                Id = 8,
                Icon = "brand8.png"
            },
            new Brand
            {
                Id = 9,
                Icon = "brand9.png"
            }
            );

            modelBuilder.Entity<Category>().HasData(
            new Category
            {
                Id = 1,
                Name = "Electronics",
            },
            new Category
            {
                Id = 2,
                Name = "Gift Ideas",
            },
            new Category
            {
                Id = 3,
                Name = "Beds",
            },
            new Category
            {
                Id = 4,
                Name = "Lighting",
            },
            new Category
            {
                Id = 5,
                Name = "Sofas & Sleeper sofas",
            },
            new Category
            {
                Id = 6,
                Name = "Storage",
            },
            new Category
            {
                Id = 7,
                Name = "Armchairs & Chaises",
            },
            new Category
            {
                Id = 8,
                Name = "Decoration",
            },
            new Category
            {
                Id = 9,
                Name = "Kitchen Cabinets",
            },
            new Category
            {
                Id = 10,
                Name = "Coffee & Tables",
            },
            new Category
            {
                Id = 11,
                Name = "Outdoor Furniture",
            }
            );

            modelBuilder.Entity<Color>().HasData(
            new Color
            {
                Id = 1,
                Name = "Blue"
            },
            new Color
            {
                Id = 2,
                Name = "Black"
            },
            new Color
            {
                Id = 3,
                Name = "White"
            },
            new Color
            {
                Id = 4,
                Name = "Red"
            },
            new Color
            {
                Id = 5,
                Name = "Yellow"
            }
            );

            modelBuilder.Entity<Discount>().HasData(
            new Discount 
            { 
                Id= 1,
                Name = "Black Friday",
                Percent = 70
            },
            new Discount
            {
                Id = 2,
                Name = "Spring Discount",
                Percent = 50
            },
            new Discount
            {
                Id = 3,
                Name = "No Discount",
                Percent = 0
            }
            );
            modelBuilder.Entity<Size>().HasData(
            new Size
            {
                Id = 1,
                Name = "Small",
            },
            new Size
            {
                Id = 2,
                Name = "Medium"
            },
            new Size
            {
                Id = 3,
                Name = "Large"
            }
            );

            modelBuilder.Entity<Product>().HasData(
            new Product
            {
                Id = 1,
                Name = "Apple MacBook Pro 14 MPHK3RU/A Silver",
                Price= 7489,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 20000,
                Rating = 5,
                CategoryId = 1,
                ColorId = 2,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 2,
                Name = "iPhone 14 Pro 256 GB Deep Purple",
                Price = 3149,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 2500,
                Rating = 3,
                CategoryId = 1,
                ColorId = 3,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 3,
                Name = "2E Gaming Set of wheels Clear / 2E-GWH-002-CL",
                Price = 49,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 100,
                Rating = 2,
                CategoryId = 2,
                ColorId = 2,
                DiscountId = 2,
                SizeId = 2
            },
            new Product
            {
                Id = 4,
                Name = "Gaming Floor Mat Canyon Camouflage / CND-SFM02",
                Price = 79,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 100,
                Rating = 1,
                CategoryId = 2,
                ColorId = 1,
                DiscountId = 1,
                SizeId = 1
            },
            new Product
            {
                Id = 5,
                Name = "Gala Wood",
                Price = 4899,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 900,
                Rating = 5,
                CategoryId = 3,
                ColorId = 5,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 6,
                Name = "İmfa Viva",
                Price = 2599,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 800,
                Rating = 4,
                CategoryId = 3,
                ColorId = 4,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 7,
                Name = "Beurer SL10",
                Price = 79,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 2600,
                Rating = 3,
                CategoryId = 4,
                ColorId = 3,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 8,
                Name = "Smart Solar",
                Price = 79,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 20,
                Rating = 2,
                CategoryId = 4,
                ColorId = 2,
                DiscountId = 2,
                SizeId = 2
            },
            new Product
            {
                Id = 9,
                Name = "Gala Astana",
                Price = 2999,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 4200,
                Rating = 1,
                CategoryId = 5,
                ColorId = 1,
                DiscountId = 1,
                SizeId = 1
            },
            new Product
            {
                Id = 10,
                Name = "Alzzoni Paris",
                Price = 2249,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 2000,
                Rating = 5,
                CategoryId = 5,
                ColorId = 5,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 11,
                Name = "Tramontina Food Storage",
                Price = 33,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 500,
                Rating = 4,
                CategoryId = 6,
                ColorId = 4,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 12,
                Name = "Car Storage",
                Price = 22,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 6200,
                Rating = 3,
                CategoryId = 6,
                ColorId = 3,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 13,
                Name = "CAM Scudo 166",
                Price = 749,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 1200,
                Rating = 2,
                CategoryId = 7,
                ColorId = 2,
                DiscountId = 2,
                SizeId = 2
            },
            new Product
            {
                Id = 14,
                Name = "Softaç Art",
                Price = 539,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 4200,
                Rating = 1,
                CategoryId = 7,
                ColorId = 1,
                DiscountId = 1,
                SizeId = 1
            },
            new Product
            {
                Id = 15,
                Name = "Chicco",
                Price = 69,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 1000,
                Rating = 5,
                CategoryId = 8,
                ColorId = 5,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 16,
                Name = "Hape",
                Price = 129,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 2100,
                Rating = 4,
                CategoryId = 8,
                ColorId = 4,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 17,
                Name = "La Sommeliere ",
                Price = 2199,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 2300,
                Rating = 3,
                CategoryId = 9,
                ColorId = 3,
                DiscountId = 3,
                SizeId = 3
            },
            new Product
            {
                Id = 18,
                Name = "Pozis FH",
                Price = 899,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 200,
                Rating = 2,
                CategoryId = 9,
                ColorId = 2,
                DiscountId = 2,
                SizeId = 2
            },
            new Product
            {
                Id = 19,
                Name = "AEG KKK994500T",
                Price = 7199,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 240,
                Rating = 1,
                CategoryId = 10,
                ColorId = 1,
                DiscountId = 1,
                SizeId = 1
            },
            new Product
            {
                Id = 20,
                Name = "Philips EP2236/40",
                Price = 1699,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 2000,
                Rating = 3,
                CategoryId = 10,
                ColorId = 2,
                DiscountId = 2,
                SizeId = 3
            },
            new Product
            {
                Id = 21,
                Name = "Karcher K5 EU",
                Price = 1059,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 270,
                Rating = 5,
                CategoryId = 11,
                ColorId = 2,
                DiscountId = 3,
                SizeId = 2
            },
            new Product
            {
                Id = 22,
                Name = "Total TGT11276/3000w",
                Price = 2299,
                Description = "Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Donec odio. Quisque",
                SellCount = 500,
                Rating = 5,
                CategoryId = 11,
                ColorId = 2,
                DiscountId = 3,
                SizeId = 1
            }
            );

            modelBuilder.Entity<ProductImage>().HasData(
            new ProductImage
            {
                Id= 1,
                Image = "notebook.png",
                IsMain = true,
                ProductId = 1
            },
            new ProductImage
            {
                Id = 2,
                Image = "notebook2.png",
                IsMain = false,
                ProductId = 1
            },
            new ProductImage
            {
                Id = 3,
                Image = "phone.png",
                IsMain = true,
                ProductId = 1
            },
            new ProductImage
            {
                Id = 4,
                Image = "phone2.png",
                IsMain = false,
                ProductId = 1
            },
            new ProductImage
            {
                Id = 5,
                Image = "canyon2.png",
                IsMain = true,
                ProductId = 2
            },
            new ProductImage
            {
                Id = 6,
                Image = "gift2.png",
                IsMain = true,
                ProductId = 2
            },
            new ProductImage
            {
                Id = 7,
                Image = "beds.png",
                IsMain = true,
                ProductId = 3
            },
            new ProductImage
            {
                Id = 8,
                Image = "beds1.png",
                IsMain = false,
                ProductId = 3
            },
            new ProductImage
            {
                Id = 9,
                Image = "beds2.png",
                IsMain = true,
                ProductId = 3
            },
            new ProductImage
            {
                Id = 10,
                Image = "beds3.png",
                IsMain = false,
                ProductId = 3
            },
            new ProductImage
            {
                Id = 11,
                Image = "light.png",
                IsMain = true,
                ProductId = 4
            },
            new ProductImage
            {
                Id = 12,
                Image = "light2.png",
                IsMain = false,
                ProductId = 4
            },
            new ProductImage
            {
                Id = 13,
                Image = "light4.png",
                IsMain = true,
                ProductId = 4
            },
            new ProductImage
            {
                Id = 14,
                Image = "sofa.png",
                IsMain = true,
                ProductId = 5
            },
            new ProductImage
            {
                Id = 15,
                Image = "sofa2.png",
                IsMain = true,
                ProductId = 5
            },
            new ProductImage
            {
                Id = 16,
                Image = "storage.png",
                IsMain = true,
                ProductId = 6
            },
            new ProductImage
            {
                Id = 17,
                Image = "storage2.png",
                IsMain = false,
                ProductId = 6
            },
            new ProductImage
            {
                Id = 18,
                Image = "stroge.png",
                IsMain = true,
                ProductId = 6
            },
            new ProductImage
            {
                Id = 19,
                Image = "chair2.png",
                IsMain = true,
                ProductId = 7
            },
            new ProductImage
            {
                Id = 20,
                Image = "chair3.png",
                IsMain = false,
                ProductId = 7
            },
            new ProductImage
            {
                Id = 21,
                Image = "chair1.png",
                IsMain = true,
                ProductId = 7
            },
            new ProductImage
            {
                Id = 22,
                Image = "decor.png",
                IsMain = true,
                ProductId = 8
            },
            new ProductImage
            {
                Id = 23,
                Image = "decor2.png",
                IsMain = false,
                ProductId = 8
            },
            new ProductImage
            {
                Id = 24,
                Image = "decor3.png",
                IsMain = true,
                ProductId = 8
            },
            new ProductImage
            {
                Id = 25,
                Image = "decor4.png",
                IsMain = false,
                ProductId = 8
            },
            new ProductImage
            {
                Id = 26,
                Image = "kitchen.png",
                IsMain = true,
                ProductId = 9
            },
            new ProductImage
            {
                Id = 27,
                Image = "kitchen2.png",
                IsMain = false,
                ProductId = 9
            },
            new ProductImage
            {
                Id = 28,
                Image = "kitchen3.png",
                IsMain = true,
                ProductId = 9
            },
            new ProductImage
            {
                Id = 29,
                Image = "kitchen4.png",
                IsMain = false,
                ProductId = 9
            },
            new ProductImage
            {
                Id = 30,
                Image = "coffee.png",
                IsMain = true,
                ProductId = 10
            },
            new ProductImage
            {
                Id = 31,
                Image = "coffee2.png",
                IsMain = true,
                ProductId = 10
            },
            new ProductImage
            {
                Id = 32,
                Image = "coffee3.png",
                IsMain = false,
                ProductId = 10
            },
            new ProductImage
            {
                Id = 33,
                Image = "outdoor.png",
                IsMain = true,
                ProductId = 11
            },
            new ProductImage
            {
                Id = 34,
                Image = "outdoor3.png",
                IsMain = true,
                ProductId = 11
            }
            );

            modelBuilder.Entity<Servic>().HasData(
            new Servic
            {
                Id= 1,
                Name = "Free Shipping",
                Description = "orders $50 or more"
            },
            new Servic
            {
                Id = 2,
                Name = "Free Returns",
                Description = "within 30 days"
            },
            new Servic
            {
                Id = 3,
                Name = "Get 20% Off 1 Item",
                Description = "When you sign up"
            },
            new Servic
            {
                Id = 4,
                Name = "We Support",
                Description = "24/7 amazing services"
            }
            );

            modelBuilder.Entity<Slider>().HasData(
            new Slider
            {
                Id =1,
                Image = "slider-1.jpeg"
            },
            new Slider
            {
                Id = 2,
                Image = "slider-2.jpeg"
            }
            );

            modelBuilder.Entity<SliderInfo>().HasData(
            new SliderInfo
            {
                Id = 1,
                Title = "Daily Deals",
                Description = "Airpods Earphones"
            },
            new SliderInfo
            {
                Id = 2,
                Title = "Deals and Promotions",
                Description = "Echo Dot 3rd Gen"
            }
            );

            modelBuilder.Entity<Team>().HasData(
            new Team
            {
                Id=1,
                Image = "member-1.jpg",
                Name = "Samanta Grey",
                Position = "Founder & CEO"
            },
            new Team
            {
                Id = 2,
                Image = "member-3.jpg",
                Name = "Janet Joy",
                Position = "Product Manager"
            },
            new Team
            {
                Id = 3,
                Image = "member-2.jpg",
                Name = "Bruce Sutton",
                Position = "Sales & Marketing Manager"
            }
            );
        }
    }
}
