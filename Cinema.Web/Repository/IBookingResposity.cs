using Cinema.Web.Models;

namespace Cinema.Web.Repository
{
    public interface IBookingResposity
    {
        Task<BookingDto> GetBokingById(int bookingId);
        Task<int> CreateBooking(BookingDto movieDto);
    }
}
