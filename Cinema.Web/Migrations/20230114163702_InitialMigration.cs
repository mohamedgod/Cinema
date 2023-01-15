using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Cinema.Web.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    MovieId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.MovieId);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    BookingId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Time = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NoOfTickets = table.Column<int>(type: "int", nullable: false),
                    User = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MovieId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_Bookings_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "MovieId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "MovieId", "Description", "ImageUrl", "Name" },
                values: new object[,]
                {
                    { 1, "Experience the once-in-a-generation movie event, exclusively in cinemas. Set more than a decade after the events of the first film, AVATAR 2 begins to tell the story of the Sully family (Jake, Neytiri, and their kids), the trouble that follows them, the lengths they go to keep each other safe, the battles they fight to stay alive and the tragedies they endure. The latest in the groundbreaking fantasy saga from director James Cameron", "/thumbnails/avatar.png", "Avatar: The Way of Water" },
                    { 2, "She’s more than just a toy. She’s part of the family. From the most prolific minds in horror—James Wan, the filmmaker behind the Saw, Insidious and The Conjuring franchises, and Blumhouse, the producer of the Halloween films, The Black Phone and The Invisible Man—comes a fresh new face in terror. M3GAN is a marvel of artificial intelligence, a life-like doll programmed to be a child’s greatest companion and a parent’s greatest ally.", "/thumbnails/megan.png", "M3GAN" },
                    { 3, "From Academy Award®-winning director and writer Sam Mendes, EMPIRE OF LIGHT is an intimate and moving story about love, friendship, and connection, set in a coastal town in Southern England against the social turmoil of the early 1980s. Hilary (Olivia Colman), a woman with a difficult past and an uneasy present, is part of a makeshift family at the old Empire Cinema on the seafront. When Stephen (Micheal Ward) is hired to work in the cinema, the two find an unlikely attraction and discover the healing power of movies, music and community.", "/empire_of_light.png", "Empire of Light" },
                    { 4, "Based on the comical and moving # 1 New York Times bestseller, A Man Called Otto tells the story of Otto Anderson (Tom Hanks), a grumpy widower who is very set in his ways. When a lively young family moves in next door, he meets his match in quick-witted and very pregnant Marisol, leading to an unlikely friendship that will turn his world upside-down. Experience a funny, heartwarming story about how some families come from the most unexpected places.", "/thumbnails/a_man_called_otto.png", "A Man Called Otto" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_MovieId",
                table: "Bookings",
                column: "MovieId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
