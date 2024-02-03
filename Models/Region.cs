using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class Region
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; }
    }
}

