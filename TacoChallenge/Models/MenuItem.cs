using System.ComponentModel.DataAnnotations;

namespace TacoChallenge.Models
{
    public class MenuItem
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}