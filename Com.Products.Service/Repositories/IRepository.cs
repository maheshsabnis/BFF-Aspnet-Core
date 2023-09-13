using Com.Products.Service.Models;

namespace Com.Products.Service.Repositories
{
    public interface IRepository
    {
        IEnumerable<Products.Service.Models.Products> GetProducts();
    }
}
