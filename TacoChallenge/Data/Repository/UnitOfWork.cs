using TacoChallenge.Data.Model;
using TacoChallenge.Data.Repository.IRepository;

namespace TacoChallenge.Data.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RestaurantContext _db;

        public IRestaurantRepository Restaurant { get; private set; }

        public UnitOfWork(RestaurantContext db)
        {
            _db = db;
            Restaurant = new RestaurantRepository(_db);
        }

        public void Dispose()
        {
            _db.Dispose();
        }
    }
}