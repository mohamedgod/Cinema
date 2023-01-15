using System.ComponentModel.DataAnnotations;

namespace Cinema.Web.Models
{
    public class Movie
    {

        public int MovieId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string ImageUrl { get; set; }

        public virtual List<Booking> Bookings { get; set; }
    }
}
