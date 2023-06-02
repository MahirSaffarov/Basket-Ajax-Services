namespace Molla.Models
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int SellCount { get; set; }
        public int Rating { get; set; }
        public int? DiscountId { get; set; }
        public Discount Discount { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductImage> ProductImage { get; set; }
        public int ColorId { get; set; }
        public  Color Color { get; set; }
        public int SizeId { get; set; }
        public Size Size { get; set; }
    }
}
