using Com.Manufacturer.Service.Models;

namespace Com.Manufacturer.Service.Repositories
{
    public class RepositoryService : IRepository
    {
        ManufacturerDB db;
        public RepositoryService()
        {
            db = new ManufacturerDB();
        }
        IEnumerable<Manufacturers> IRepository.GetManufacturers()
        {
            return db;
        }
    }
}
