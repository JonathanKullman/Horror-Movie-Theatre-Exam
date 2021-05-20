using Microsoft.EntityFrameworkCore;
using System;

namespace Backend
{
    public class HorrorTheatreContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Theatre> Theatres { get; set; }
        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=HorrorTheatreDB;Trusted_Connection=True;").UseLazyLoadingProxies();
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        Id = 1,
                        Name = "Alien",
                        Summary = "After a space merchant vessel receives an unknown transmission as a distress call, " +
                      "one of the crew is attacked by a mysterious life form and they soon realize that its life cycle " +
                      "has merely begun.",
                        PathOfPicture = "AlienPoster.jpg"
                    },
                    new Movie
                    {
                        Id = 2,
                        Name = "A Quiet Place",
                        Summary = "In a post-apocalyptic world, a family is forced to live in silence while hiding " +
                        "from monsters with ultra-sensitive hearing.",
                        PathOfPicture = "AQuietPlacePoster.jpg"
                    },
                    new Movie
                    {
                        Id = 3,
                        Name = "Paranormal Activity",
                        Summary = "After moving into a suburban home, a couple becomes increasingly " +
                        "disturbed by a nightly demonic presence.",
                        PathOfPicture = "ParanormalActivityPoster.jpg"
                    },
                    new Movie
                    {
                        Id = 4,
                        Name = "It",
                        Summary = "In the summer of 1989, a group of bullied kids band together to destroy " +
                           "a shape-shifting monster, which disguises itself as a clown and preys on the " +
                           "children of Derry, their small Maine town.",
                        PathOfPicture = "ItPoster.jpg"
                    },
                    new Movie
                    {
                        Id = 5,
                        Name = "Saw",
                        Summary = "Two strangers awaken in a room with no recollection of how they got there, " +
                         "and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer.",
                        PathOfPicture = "SawPoster.jpg"
                    },
                    new Movie
                    {
                        Id = 6,
                        Name = "The Grudge",
                        Summary = "A mysterious and vengeful spirit marks and pursues anybody who dares enter the" +
                        " house in which it resides.",
                        PathOfPicture = "TheGrudgePoster.jpg"
                    },
                    new Movie
                    {
                        Id = 7,
                        Name = "Dawn of the Dead",
                        Summary = "A nurse, a policeman, a young married couple, a salesman and other survivors of " +
                        "a worldwide plague that is producing aggressive, flesh-eating zombies, " +
                        "take refuge in a mega Midwestern shopping mall.",
                        PathOfPicture = "TheDawnOfTheDeadPoster.jpg"
                    },
                    new Movie
                    {
                        Id = 8,
                        Name = "Scream",
                        Summary = "A year after the murder of her mother, a teenage girl is terrorized by a new killer, " +
                        "who targets the girl and her friends by using horror films as part of a deadly game.",
                        PathOfPicture = "ScreamPoster.jpg"
                    },
                    new Movie
                    {
                        Id = 9,
                        Name = "The Blair Witch Project",
                        Summary = "Three film students vanish after traveling into a Maryland forest to film a documentary " +
                        "on the local Blair Witch legend, leaving only their footage behind.",
                        PathOfPicture = "TheBlairWitchProjectPoster.jpg"
                    },
                    new Movie
                    {
                        Id = 10,
                        Name = "The Shining",
                        Summary = "A family heads to an isolated hotel for the winter where a sinister presence influences " +
                        "the father into violence, while his psychic son sees horrific forebodings from both past and future.",
                        PathOfPicture = "TheBlairWitchProjectPoster.jpg"
                    });

            modelBuilder.Entity<Theatre>().HasData(
                new Theatre { Id = 1, MovieId = 1, HallNumber = 1, StartTime = new DateTime(2020, 06, 15, 20, 00, 00), GotWheelchairRamp = false, OccupiedSeats = 2 },
                new Theatre { Id = 2, MovieId = 2, HallNumber = 2, StartTime = new DateTime(2020, 06, 15, 20, 00, 00), GotWheelchairRamp = false, OccupiedSeats = 1 },
                new Theatre { Id = 3, MovieId = 4, HallNumber = 3, StartTime = new DateTime(2020, 06, 15, 20, 00, 00), GotWheelchairRamp = false, OccupiedSeats = 1 },
                new Theatre { Id = 4, MovieId = 7, HallNumber = 4, StartTime = new DateTime(2020, 06, 15, 20, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 5, MovieId = 3, HallNumber = 5, StartTime = new DateTime(2020, 06, 15, 20, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 6, MovieId = 5, HallNumber = 6, StartTime = new DateTime(2020, 06, 15, 20, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 7, MovieId = 8, HallNumber = 7, StartTime = new DateTime(2020, 06, 15, 20, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 8, MovieId = 9, HallNumber = 8, StartTime = new DateTime(2020, 06, 15, 20, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 9, MovieId = 6, HallNumber = 9, StartTime = new DateTime(2020, 06, 15, 20, 00, 00), GotWheelchairRamp = true, OccupiedSeats = 1 },
                new Theatre { Id = 10, MovieId = 10, HallNumber = 10, StartTime = new DateTime(2020, 06, 15, 20, 00, 00), GotWheelchairRamp = true },


                new Theatre { Id = 11, MovieId = 10, HallNumber = 1, StartTime = new DateTime(2020, 06, 15, 22, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 12, MovieId = 2, HallNumber = 2, StartTime = new DateTime(2020, 06, 15, 22, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 13, MovieId = 4, HallNumber = 3, StartTime = new DateTime(2020, 06, 15, 22, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 14, MovieId = 7, HallNumber = 4, StartTime = new DateTime(2020, 06, 15, 22, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 15, MovieId = 3, HallNumber = 5, StartTime = new DateTime(2020, 06, 15, 22, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 16, MovieId = 5, HallNumber = 6, StartTime = new DateTime(2020, 06, 15, 22, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 17, MovieId = 8, HallNumber = 7, StartTime = new DateTime(2020, 06, 15, 22, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 18, MovieId = 6, HallNumber = 8, StartTime = new DateTime(2020, 06, 15, 22, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 19, MovieId = 1, HallNumber = 9, StartTime = new DateTime(2020, 06, 15, 22, 00, 00), GotWheelchairRamp = true },
                new Theatre { Id = 20, MovieId = 9, HallNumber = 10, StartTime = new DateTime(2020, 06, 15, 22, 00, 00), GotWheelchairRamp = true },


                new Theatre { Id = 21, MovieId = 1, HallNumber = 1, StartTime = new DateTime(2020, 06, 16, 00, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 22, MovieId = 10, HallNumber = 2, StartTime = new DateTime(2020, 06, 16, 00, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 23, MovieId = 4, HallNumber = 3, StartTime = new DateTime(2020, 06, 16, 00, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 24, MovieId = 7, HallNumber = 4, StartTime = new DateTime(2020, 06, 16, 00, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 25, MovieId = 3, HallNumber = 5, StartTime = new DateTime(2020, 06, 16, 00, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 26, MovieId = 5, HallNumber = 6, StartTime = new DateTime(2020, 06, 16, 00, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 27, MovieId = 6, HallNumber = 7, StartTime = new DateTime(2020, 06, 16, 00, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 28, MovieId = 9, HallNumber = 8, StartTime = new DateTime(2020, 06, 16, 00, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 29, MovieId = 2, HallNumber = 9, StartTime = new DateTime(2020, 06, 16, 00, 00, 00), GotWheelchairRamp = true },
                new Theatre { Id = 30, MovieId = 8, HallNumber = 10, StartTime = new DateTime(2020, 06, 16, 00, 00, 00), GotWheelchairRamp = true },


                new Theatre { Id = 31, MovieId = 1, HallNumber = 1, StartTime = new DateTime(2020, 06, 16, 02, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 32, MovieId = 2, HallNumber = 2, StartTime = new DateTime(2020, 06, 16, 02, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 33, MovieId = 4, HallNumber = 3, StartTime = new DateTime(2020, 06, 16, 02, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 34, MovieId = 6, HallNumber = 4, StartTime = new DateTime(2020, 06, 16, 02, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 35, MovieId = 10, HallNumber = 5, StartTime = new DateTime(2020, 06, 16, 02, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 36, MovieId = 5, HallNumber = 6, StartTime = new DateTime(2020, 06, 16, 02, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 37, MovieId = 8, HallNumber = 7, StartTime = new DateTime(2020, 06, 16, 02, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 38, MovieId = 9, HallNumber = 8, StartTime = new DateTime(2020, 06, 16, 02, 00, 00), GotWheelchairRamp = false },
                new Theatre { Id = 39, MovieId = 3, HallNumber = 9, StartTime = new DateTime(2020, 06, 16, 02, 00, 00), GotWheelchairRamp = true },
                new Theatre { Id = 40, MovieId = 7, HallNumber = 10, StartTime = new DateTime(2020, 06, 16, 02, 00, 00), GotWheelchairRamp = true }
                );

            modelBuilder.Entity<Customer>().HasData(


                new Customer { Id = 1, FirstName = "Bengt", LastName = "Adolfsson", PhoneNumber = "0721111111" },

                new Customer { Id = 2, FirstName = "Elof", LastName = "Albertsson", PhoneNumber = "0722222222" },

                new Customer { Id = 3, FirstName = "Sven", LastName = "Svensson", PhoneNumber = "0723333333" },

                new Customer { Id = 4, FirstName = "Ingrid", LastName = "Eriksson", PhoneNumber = "0724444444" },

                new Customer { Id = 5, FirstName = "Elin", LastName = "Hermansson", PhoneNumber = "0725555555" }
                );



            modelBuilder.Entity<Ticket>().HasData(

                new Ticket { Id = 1, CustomerId = 1, TheatreId = 1, Seat = 1, Wheelchair = false },
                new Ticket { Id = 2, CustomerId = 2, TheatreId = 1, Seat = 2, Wheelchair = false },
                new Ticket { Id = 3, CustomerId = 3, TheatreId = 2, Seat = 1, Wheelchair = false },
                new Ticket { Id = 4, CustomerId = 4, TheatreId = 3, Seat = 1, Wheelchair = false },
                new Ticket { Id = 5, CustomerId = 5, TheatreId = 9, Seat = 1, Wheelchair = true }

                );

        }

    }
}
