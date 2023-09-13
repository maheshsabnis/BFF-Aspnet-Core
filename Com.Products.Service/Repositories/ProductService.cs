using Com.Products.Service.Models;

namespace Com.Products.Service.Repositories
{
    public class ProductService : IRepository
    {
        ProductDb db;

        public ProductService()
        {
            db = new ProductDb();
        }

        IEnumerable<Models.Products> IRepository.GetProducts()
        {
            return db;
        }
    }
}
