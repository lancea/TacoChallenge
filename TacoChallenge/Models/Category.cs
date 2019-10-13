using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TacoChallenge.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } // Hmm, catergory does not have an id

        public string Name { get; set; }
        public List<MenuItem> MenuItems { get; set; }
    }
}