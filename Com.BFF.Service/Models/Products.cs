namespace Com.BFF.Service.Models
{
    public class Products
    {
        public int ProductId { get; set; } = 0;
        public string? ProductName { get; set; }
        public string? Specifications { get; set; }
        public decimal Price { get; set; } = 0;
        public int ManufacturerId { get; set; } = 0;
    }
}
