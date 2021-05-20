﻿// <auto-generated />
using System;
using Backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Backend.Migrations
{
    [DbContext(typeof(HorrorTheatreContext))]
    partial class HorrorTheatreContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Backend.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Backend.Movie", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathOfPicture")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Summary")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Movies");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Alien",
                            PathOfPicture = "AlienPoster.jpg",
                            Summary = "After a space merchant vessel receives an unknown transmission as a distress call, one of the crew is attacked by a mysterious life form and they soon realize that its life cycle has merely begun."
                        },
                        new
                        {
                            Id = 2,
                            Name = "A Quiet Place",
                            PathOfPicture = "AQuietPlacePoster.jpg",
                            Summary = "In a post-apocalyptic world, a family is forced to live in silence while hiding from monsters with ultra-sensitive hearing."
                        },
                        new
                        {
                            Id = 3,
                            Name = "Paranormal Activity",
                            PathOfPicture = "ParanormalActivityPoster.jpg",
                            Summary = "After moving into a suburban home, a couple becomes increasingly disturbed by a nightly demonic presence."
                        },
                        new
                        {
                            Id = 4,
                            Name = "It",
                            PathOfPicture = "ItPoster.jpg",
                            Summary = "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town."
                        },
                        new
                        {
                            Id = 5,
                            Name = "Saw",
                            PathOfPicture = "SawPoster.jpg",
                            Summary = "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer."
                        },
                        new
                        {
                            Id = 6,
                            Name = "The Grudge",
                            PathOfPicture = "TheGrudgePoster.jpg",
                            Summary = "A mysterious and vengeful spirit marks and pursues anybody who dares enter the house in which it resides."
                        },
                        new
                        {
                            Id = 7,
                            Name = "Dawn of the Dead",
                            PathOfPicture = "TheDawnOfTheDeadPoster.jpg",
                            Summary = "A nurse, a policeman, a young married couple, a salesman and other survivors of a worldwide plague that is producing aggressive, flesh-eating zombies, take refuge in a mega Midwestern shopping mall."
                        },
                        new
                        {
                            Id = 8,
                            Name = "Scream",
                            PathOfPicture = "ScreamPoster.jpg",
                            Summary = "A year after the murder of her mother, a teenage girl is terrorized by a new killer, who targets the girl and her friends by using horror films as part of a deadly game."
                        },
                        new
                        {
                            Id = 9,
                            Name = "The Blair Witch Project",
                            PathOfPicture = "TheBlairWitchProjectPoster.jpg",
                            Summary = "Three film students vanish after traveling into a Maryland forest to film a documentary on the local Blair Witch legend, leaving only their footage behind."
                        },
                        new
                        {
                            Id = 10,
                            Name = "The Shining",
                            PathOfPicture = "TheBlairWitchProjectPoster.jpg",
                            Summary = "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future."
                        });
                });

            modelBuilder.Entity("Backend.Theatre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("GotWheelchairRamp")
                        .HasColumnType("bit");

                    b.Property<int>("HallNumber")
                        .HasColumnType("int");

                    b.Property<int?>("MovieId")
                        .HasColumnType("int");

                    b.Property<int>("OccupiedSeats")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("TotalSeats")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MovieId");

                    b.ToTable("Theatres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            GotWheelchairRamp = false,
                            HallNumber = 1,
                            MovieId = 1,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 2,
                            GotWheelchairRamp = false,
                            HallNumber = 2,
                            MovieId = 2,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 3,
                            GotWheelchairRamp = false,
                            HallNumber = 3,
                            MovieId = 4,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 4,
                            GotWheelchairRamp = false,
                            HallNumber = 4,
                            MovieId = 7,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 5,
                            GotWheelchairRamp = false,
                            HallNumber = 5,
                            MovieId = 3,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 6,
                            GotWheelchairRamp = false,
                            HallNumber = 6,
                            MovieId = 5,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 7,
                            GotWheelchairRamp = false,
                            HallNumber = 7,
                            MovieId = 8,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 8,
                            GotWheelchairRamp = false,
                            HallNumber = 8,
                            MovieId = 9,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 9,
                            GotWheelchairRamp = true,
                            HallNumber = 9,
                            MovieId = 6,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 10,
                            GotWheelchairRamp = true,
                            HallNumber = 10,
                            MovieId = 10,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 11,
                            GotWheelchairRamp = false,
                            HallNumber = 1,
                            MovieId = 10,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 12,
                            GotWheelchairRamp = false,
                            HallNumber = 2,
                            MovieId = 2,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 13,
                            GotWheelchairRamp = false,
                            HallNumber = 3,
                            MovieId = 4,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 14,
                            GotWheelchairRamp = false,
                            HallNumber = 4,
                            MovieId = 7,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 15,
                            GotWheelchairRamp = false,
                            HallNumber = 5,
                            MovieId = 3,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 16,
                            GotWheelchairRamp = false,
                            HallNumber = 6,
                            MovieId = 5,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 17,
                            GotWheelchairRamp = false,
                            HallNumber = 7,
                            MovieId = 8,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 18,
                            GotWheelchairRamp = false,
                            HallNumber = 8,
                            MovieId = 6,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 19,
                            GotWheelchairRamp = true,
                            HallNumber = 9,
                            MovieId = 1,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 20,
                            GotWheelchairRamp = true,
                            HallNumber = 10,
                            MovieId = 9,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 21,
                            GotWheelchairRamp = false,
                            HallNumber = 1,
                            MovieId = 1,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 22,
                            GotWheelchairRamp = false,
                            HallNumber = 2,
                            MovieId = 10,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 23,
                            GotWheelchairRamp = false,
                            HallNumber = 3,
                            MovieId = 4,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 24,
                            GotWheelchairRamp = false,
                            HallNumber = 4,
                            MovieId = 7,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 25,
                            GotWheelchairRamp = false,
                            HallNumber = 5,
                            MovieId = 3,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 26,
                            GotWheelchairRamp = false,
                            HallNumber = 6,
                            MovieId = 5,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 27,
                            GotWheelchairRamp = false,
                            HallNumber = 7,
                            MovieId = 6,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 28,
                            GotWheelchairRamp = false,
                            HallNumber = 8,
                            MovieId = 9,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 29,
                            GotWheelchairRamp = true,
                            HallNumber = 9,
                            MovieId = 2,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 30,
                            GotWheelchairRamp = true,
                            HallNumber = 10,
                            MovieId = 8,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 31,
                            GotWheelchairRamp = false,
                            HallNumber = 1,
                            MovieId = 1,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 32,
                            GotWheelchairRamp = false,
                            HallNumber = 2,
                            MovieId = 2,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 33,
                            GotWheelchairRamp = false,
                            HallNumber = 3,
                            MovieId = 4,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 34,
                            GotWheelchairRamp = false,
                            HallNumber = 4,
                            MovieId = 6,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 35,
                            GotWheelchairRamp = false,
                            HallNumber = 5,
                            MovieId = 10,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 36,
                            GotWheelchairRamp = false,
                            HallNumber = 6,
                            MovieId = 5,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 37,
                            GotWheelchairRamp = false,
                            HallNumber = 7,
                            MovieId = 8,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 38,
                            GotWheelchairRamp = false,
                            HallNumber = 8,
                            MovieId = 9,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 39,
                            GotWheelchairRamp = true,
                            HallNumber = 9,
                            MovieId = 3,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        },
                        new
                        {
                            Id = 40,
                            GotWheelchairRamp = true,
                            HallNumber = 10,
                            MovieId = 7,
                            OccupiedSeats = 0,
                            StartTime = new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified),
                            TotalSeats = 20
                        });
                });

            modelBuilder.Entity("Backend.Ticket", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Seat")
                        .HasColumnType("int");

                    b.Property<int>("TheatreId")
                        .HasColumnType("int");

                    b.Property<bool>("Wheelchair")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.HasIndex("TheatreId");

                    b.ToTable("Tickets");
                });

            modelBuilder.Entity("Backend.Theatre", b =>
                {
                    b.HasOne("Backend.Movie", "Movie")
                        .WithMany()
                        .HasForeignKey("MovieId");

                    b.Navigation("Movie");
                });

            modelBuilder.Entity("Backend.Ticket", b =>
                {
                    b.HasOne("Backend.Customer", "Customer")
                        .WithMany("Tickets")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Backend.Theatre", "Theatre")
                        .WithMany("Tickets")
                        .HasForeignKey("TheatreId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Theatre");
                });

            modelBuilder.Entity("Backend.Customer", b =>
                {
                    b.Navigation("Tickets");
                });

            modelBuilder.Entity("Backend.Theatre", b =>
                {
                    b.Navigation("Tickets");
                });
#pragma warning restore 612, 618
        }
    }
}
