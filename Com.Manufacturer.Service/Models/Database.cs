using System.Collections.Generic;


namespace Com.Manufacturer.Service.Models
{
    public class ManufacturerDB : List<Manufacturers>
    {
        public ManufacturerDB()
        {
            Add(new Manufacturers() { ManufacturerId = 1, ManufacturerName = "MS-Tech", ContactNo = 123456, City = "Pune"});
            Add(new Manufacturers() { ManufacturerId = 2, ManufacturerName = "LS-Tech", ContactNo = 223456, City = "Pune" });
            Add(new Manufacturers() { ManufacturerId = 3, ManufacturerName = "TS-Tech", ContactNo = 323456, City = "Pune" });
            Add(new Manufacturers() { ManufacturerId = 4, ManufacturerName = "KK-Tech", ContactNo = 423456, City = "Pune" });
            Add(new Manufacturers() { ManufacturerId = 5, ManufacturerName = "SP-Tech", ContactNo = 523456, City = "Pune" });
            Add(new Manufacturers() { ManufacturerId = 6, ManufacturerName = "VP-Tech", ContactNo = 623456, City = "Pune" });
        }
    }
}
