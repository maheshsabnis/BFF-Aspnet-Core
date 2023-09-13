using Com.BFF.Service.Models;
using System.Net.Http.Json;
using System.Security.Cryptography;

namespace Com.BFF.Service.Domain
{
    public class Logic
    {
        HttpClient client;
        public Logic()
        {
            client = new HttpClient();
        }

        public async Task<IEnumerable<ProductCatalog>> GetProductCatalog()
        {
            List<ProductCatalog> productsCatalog = new List<ProductCatalog>();

            /* Get The Manufacturers */
            List<Manufacturers>? manufacturers = await client.GetFromJsonAsync<List<Manufacturers>>("http://localhost:8001/api/Manufacturers");

            /* Get The Products */

            List<Products>? products = await client.GetFromJsonAsync<List<Products>>("http://localhost:8002/api/Products");


            /* Generate Products Catalog */

            productsCatalog = (from manufacturer in manufacturers
                               from product in products
                               where manufacturer.ManufacturerId == product.ManufacturerId
                               select new ProductCatalog()
                               {
                                   ManufacturerName = manufacturer.ManufacturerName,
                                   ProductName = product.ProductName,
                                   Description = product.Specifications,
                                   Price = product.Price,
                                   Tax = Convert.ToDecimal(0.25) * product.Price,
                                   TotalPrice = (Convert.ToDecimal(0.25) * product.Price) + product.Price
                               }).ToList();

            return productsCatalog;
        }
    }
}
