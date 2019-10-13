using System.Collections.Generic;
using System.Linq;
using TacoChallenge.Data.Model;
using TacoChallenge.Data.Repository.IRepository;
using TacoChallenge.Models;

namespace TacoChallenge.Data.Repository
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        private readonly RestaurantContext _db;

        public RestaurantRepository(RestaurantContext db) : base(db)
        {
            _db = db;
        }

        public IEnumerable<Restaurant> GetRestaurantList()
        {
            return _db.Restaurant.Select(i => new Restaurant()
            {
                Id = i.Id,
                Name = i.Name
            });
        }
    }
}