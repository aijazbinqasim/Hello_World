using System.ComponentModel.DataAnnotations;

namespace Hello_World.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please provide Title")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Please provide Valid Title")]
        public string Title { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [Url]
        public string Website { get; set; }

        [Required]
        public int Price { get; set; }

        [MinLength(10)]
        public string Description { get; set; }
    }
}
