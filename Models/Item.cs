using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Item
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }

 
        public int RegionId { get; set; }
        public Region Region { get; set; }
    }
}