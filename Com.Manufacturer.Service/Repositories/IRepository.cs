using Com.Manufacturer.Service.Models;

namespace Com.Manufacturer.Service.Repositories
{
    public interface IRepository
    {
        public IEnumerable<Manufacturers> GetManufacturers();
    }
}
