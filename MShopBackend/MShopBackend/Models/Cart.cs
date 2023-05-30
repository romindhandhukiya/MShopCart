namespace MShopBackend.Models
{
    public class Cart
    {
            public int CartId { get; set; }
            public int ProductId { get; set; }
            public decimal TotalPrice { get; set; } 
            public int ProductQuantity { get; set; }

    }
}
