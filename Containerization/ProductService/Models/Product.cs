namespace Containerization.ProductService.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Brand {  get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;

        public Product(int id, string name, string brand, string description, decimal price)
        {
            Id = id;
            Name = name;
            Brand = brand;
            Description = description;
            Price = price;
        }
    }
}
