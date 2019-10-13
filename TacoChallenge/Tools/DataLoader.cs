using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;
using TacoChallenge.Data.Model;
using TacoChallenge.Models;

namespace TacoChallenge.Tools
{
    public class DataLoader : IDataLoader
    {
        private RestaurantContext _context;

        public DataLoader(RestaurantContext context)
        {
            _context = context;
        }

        public void LoadIt(string jsonData)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                ContractResolver = new PrivateSetterContractResolver()
            };
            _context.Database.EnsureDeleted();
            _context.Database.EnsureCreated();

            List<JObject> random = JsonConvert.DeserializeObject<List<JObject>>(jsonData, settings);
            jsonData = JsonConvert.SerializeObject(random);

            List<Restaurant> restaurants =
           JsonConvert.DeserializeObject<List<Restaurant>>(jsonData, settings);

            if (!_context.Restaurants.Any())
            {
                _context.AddRange(restaurants);
                _context.SaveChanges();
            }
        }
    }
}