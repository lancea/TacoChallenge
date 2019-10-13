using System.Collections.Generic;
using TacoChallenge.Models;

namespace TacoChallenge.Data.Repository.IRepository
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        IEnumerable<Restaurant> GetRestaurantList();
    }
}