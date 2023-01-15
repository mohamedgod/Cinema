using System.ComponentModel.DataAnnotations;

namespace Cinema.Web.Models
{
    public class MovieDto
    {
        public MovieDto()
        {
            Count = 1;
        }
        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Ticket Field is required")]
        [Range(1, 100)]
        public int Count { get; set; }
    }
}
