using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TacoChallenge.Models
{
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public string City { get; set; }
        public string Suburb { get; set; }
        public string LogoPath { get; set; }
        public int Rank { get; set; }
        public List<Category> Categories { get; set; }
    }
}