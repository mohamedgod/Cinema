using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Cinema.Web.Models
{
    public class BookingDto
    {
        public int BookingId { get; set; }
        public DateTime Date { get; set; }
        public string Time { get; set; }

        [Required]
        public int NoOfTickets { get; set; }
        public string User { get; set; }
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
