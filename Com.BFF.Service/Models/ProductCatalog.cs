namespace Com.BFF.Service.Models
{
    public class ProductCatalog
    {
        public string? ProductName { get; set; }
        public string? ManufacturerName { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; } = 0;
        public decimal Tax { get; set; } = 0;
        public decimal TotalPrice { get; set; } = 0;
    }
}
