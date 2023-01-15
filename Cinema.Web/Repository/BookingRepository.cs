using AutoMapper;
using Cinema.Web.DbContexts;
using Cinema.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.Repository
{
    public class BookingRepository : IBookingResposity
    {
        private readonly ApplicationDbContext _db;
        private IMapper _mapper;
        public BookingRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<int> CreateBooking(BookingDto bookingDto)
        {
            var booking = _mapper.Map<BookingDto, Booking>(bookingDto);

            _db.Bookings.Add(booking);

            await _db.SaveChangesAsync();

            return booking.BookingId;

        }

        public async Task<BookingDto> GetBokingById(int bookingId)
        {
            var booking = await _db.Bookings
                .Include(m => m.Movie)
                .FirstOrDefaultAsync(b => b.BookingId == bookingId);

            return _mapper.Map<BookingDto>(booking);
        }
    }
}
