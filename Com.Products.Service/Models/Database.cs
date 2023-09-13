namespace Com.Products.Service.Models
{
    public class ProductDb : List<Products>
    {
        public ProductDb()
        {
            Add(new Products() { ProductId = 1001, ProductName = "Laptop", Specifications = "32 GB Gaming Laptop", Price = 450000, ManufacturerId = 1});
            Add(new Products() { ProductId = 1002, ProductName = "Desktop", Specifications = "16 GB Workstation", Price = 50000, ManufacturerId = 2 });
            Add(new Products() { ProductId = 1003, ProductName = "RAM", Specifications = "32 GB DDR 4", Price = 45000, ManufacturerId = 3 });
            Add(new Products() { ProductId = 1004, ProductName = "Printer", Specifications = "Lazer Printer", Price = 4500, ManufacturerId = 4 });
            Add(new Products() { ProductId = 1005, ProductName = "Memory Card", Specifications = "128 GB Storage", Price = 2500, ManufacturerId = 1 });
            Add(new Products() { ProductId = 1006, ProductName = "DVD Writer", Specifications = "100 MBPS Fast Writer", Price = 1500, ManufacturerId = 2 });
            Add(new Products() { ProductId = 1007, ProductName = "Power Adapter", Specifications = "64 KVA 18 Hrs. Backup", Price = 500, ManufacturerId = 3 });
            Add(new Products() { ProductId = 1008, ProductName = "Keyboard", Specifications = "105 Keys Gaming", Price = 1500, ManufacturerId = 4 });
            Add(new Products() { ProductId = 1009, ProductName = "Mouse", Specifications = "Wired USB Mouse", Price = 500, ManufacturerId = 1 });
            Add(new Products() { ProductId = 1010, ProductName = "Hard Disk", Specifications = "5 TB Fast Storage", Price = 15000, ManufacturerId = 2 });
            Add(new Products() { ProductId = 1011, ProductName = "USB Drive", Specifications = "64 GB Storage", Price = 5000, ManufacturerId = 3 });
            Add(new Products() { ProductId = 1012, ProductName = "Monitor", Specifications = "52 Inches UHD", Price = 3000, ManufacturerId = 4 });
            Add(new Products() { ProductId = 1013, ProductName = "Laptop", Specifications = "64 GB Gaming Laptop with Developer Workstation", Price = 550000, ManufacturerId = 1 });
            Add(new Products() { ProductId = 1014, ProductName = "Desktop", Specifications = "512 GB RAM Server Machine", Price = 35000, ManufacturerId = 2 });
            Add(new Products() { ProductId = 1015, ProductName = "Keyboard", Specifications = "120 Keys Optical External Keyboard", Price = 1700, ManufacturerId = 3 });
            Add(new Products() { ProductId = 1016, ProductName = "Mouse", Specifications = "Optical Gaming Mouse", Price = 1800, ManufacturerId = 4 });
            Add(new Products() { ProductId = 1017, ProductName = "RAM", Specifications = "32 GB DDR 6 RAM", Price = 7500, ManufacturerId = 1 });
            Add(new Products() { ProductId = 1018, ProductName = "Hard Disk", Specifications = "6 TB Fast Storage", Price = 6300, ManufacturerId = 2 });
            Add(new Products() { ProductId = 1019, ProductName = "Power Adapter", Specifications = "24 Hrs. Backup for Servers", Price = 9500, ManufacturerId = 3 });
            Add(new Products() { ProductId = 1020, ProductName = "DVD Writer", Specifications = "Fast Blue Ray Writer", Price = 3700, ManufacturerId = 4 });
            Add(new Products() { ProductId = 1021, ProductName = "Desktop", Specifications = "Server Machines", Price = 85000, ManufacturerId = 1 });
            Add(new Products() { ProductId = 1022, ProductName = "Printer", Specifications = "4-In-1 Printer", Price = 6400, ManufacturerId = 2 });
            Add(new Products() { ProductId = 1023, ProductName = "Router", Specifications = "1000/Mbps Fast Messager", Price = 1200, ManufacturerId = 3 });
            Add(new Products() { ProductId = 1024, ProductName = "Blade Server", Specifications = "Mult-Vm Storage", Price = 4650000, ManufacturerId = 4 });
        }
    }
}
