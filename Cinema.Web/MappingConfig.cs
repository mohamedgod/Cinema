using AutoMapper;
using Cinema.Web.Models;

namespace Cinema.Web
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<MovieDto, Movie>().ReverseMap();

                config.CreateMap<BookingDto, Booking>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}