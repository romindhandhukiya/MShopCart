namespace MShopBackend.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Name { get; set; } = "null";
        public decimal Price { get; set; }
        public string ImageUrl { get; set; } = "null";
        public int Quantity { get; set; } = 1;

    }
}
