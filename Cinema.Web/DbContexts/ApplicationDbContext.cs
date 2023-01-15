using Cinema.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Cinema.Web.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                MovieId = 1,
                Name = "Avatar: The Way of Water",
                Description = "Experience the once-in-a-generation movie event, exclusively in cinemas. Set more than a decade after the events of the first film, AVATAR 2 begins to tell the story of the Sully family (Jake, Neytiri, and their kids), the trouble that follows them, the lengths they go to keep each other safe, the battles they fight to stay alive and the tragedies they endure. The latest in the groundbreaking fantasy saga from director James Cameron",
                ImageUrl = "/thumbnails/avatar.png"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                MovieId = 2,
                Name = "M3GAN",
                Description = "She’s more than just a toy. She’s part of the family. From the most prolific minds in horror—James Wan, the filmmaker behind the Saw, Insidious and The Conjuring franchises, and Blumhouse, the producer of the Halloween films, The Black Phone and The Invisible Man—comes a fresh new face in terror. M3GAN is a marvel of artificial intelligence, a life-like doll programmed to be a child’s greatest companion and a parent’s greatest ally.",
                ImageUrl = "/thumbnails/megan.png"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                MovieId = 3,
                Name = "Empire of Light",
                Description = "From Academy Award®-winning director and writer Sam Mendes, EMPIRE OF LIGHT is an intimate and moving story about love, friendship, and connection, set in a coastal town in Southern England against the social turmoil of the early 1980s. Hilary (Olivia Colman), a woman with a difficult past and an uneasy present, is part of a makeshift family at the old Empire Cinema on the seafront. When Stephen (Micheal Ward) is hired to work in the cinema, the two find an unlikely attraction and discover the healing power of movies, music and community.",
                ImageUrl = "/thumbnails/empire_of_light.png"
            });
            modelBuilder.Entity<Movie>().HasData(new Movie
            {
                MovieId = 4,
                Name = "A Man Called Otto",
                Description = "Based on the comical and moving # 1 New York Times bestseller, A Man Called Otto tells the story of Otto Anderson (Tom Hanks), a grumpy widower who is very set in his ways. When a lively young family moves in next door, he meets his match in quick-witted and very pregnant Marisol, leading to an unlikely friendship that will turn his world upside-down. Experience a funny, heartwarming story about how some families come from the most unexpected places.",
                ImageUrl = "/thumbnails/a_man_called_otto.png"
            });
        }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
