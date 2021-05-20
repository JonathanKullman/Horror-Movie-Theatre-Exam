using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathOfPicture = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Theatres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieId = table.Column<int>(type: "int", nullable: true),
                    TotalSeats = table.Column<int>(type: "int", nullable: false),
                    HallNumber = table.Column<int>(type: "int", nullable: false),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GotWheelchairRamp = table.Column<bool>(type: "bit", nullable: false),
                    OccupiedSeats = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Theatres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Theatres_Movies_MovieId",
                        column: x => x.MovieId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TheatreId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    Seat = table.Column<int>(type: "int", nullable: false),
                    Wheelchair = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tickets_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tickets_Theatres_TheatreId",
                        column: x => x.TheatreId,
                        principalTable: "Theatres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "PathOfPicture", "Summary" },
                values: new object[,]
                {
                    { 1, "Alien", "AlienPoster.jpg", "After a space merchant vessel receives an unknown transmission as a distress call, one of the crew is attacked by a mysterious life form and they soon realize that its life cycle has merely begun." },
                    { 2, "A Quiet Place", "AQuietPlacePoster.jpg", "In a post-apocalyptic world, a family is forced to live in silence while hiding from monsters with ultra-sensitive hearing." },
                    { 3, "Paranormal Activity", "ParanormalActivityPoster.jpg", "After moving into a suburban home, a couple becomes increasingly disturbed by a nightly demonic presence." },
                    { 4, "It", "ItPoster.jpg", "In the summer of 1989, a group of bullied kids band together to destroy a shape-shifting monster, which disguises itself as a clown and preys on the children of Derry, their small Maine town." },
                    { 5, "Saw", "SawPoster.jpg", "Two strangers awaken in a room with no recollection of how they got there, and soon discover they're pawns in a deadly game perpetrated by a notorious serial killer." },
                    { 6, "The Grudge", "TheGrudgePoster.jpg", "A mysterious and vengeful spirit marks and pursues anybody who dares enter the house in which it resides." },
                    { 7, "Dawn of the Dead", "TheDawnOfTheDeadPoster.jpg", "A nurse, a policeman, a young married couple, a salesman and other survivors of a worldwide plague that is producing aggressive, flesh-eating zombies, take refuge in a mega Midwestern shopping mall." },
                    { 8, "Scream", "ScreamPoster.jpg", "A year after the murder of her mother, a teenage girl is terrorized by a new killer, who targets the girl and her friends by using horror films as part of a deadly game." },
                    { 9, "The Blair Witch Project", "TheBlairWitchProjectPoster.jpg", "Three film students vanish after traveling into a Maryland forest to film a documentary on the local Blair Witch legend, leaving only their footage behind." },
                    { 10, "The Shining", "TheBlairWitchProjectPoster.jpg", "A family heads to an isolated hotel for the winter where a sinister presence influences the father into violence, while his psychic son sees horrific forebodings from both past and future." }
                });

            migrationBuilder.InsertData(
                table: "Theatres",
                columns: new[] { "Id", "GotWheelchairRamp", "HallNumber", "MovieId", "OccupiedSeats", "StartTime", "TotalSeats" },
                values: new object[,]
                {
                    { 1, false, 1, 1, 0, new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 27, false, 7, 6, 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 34, false, 4, 6, 0, new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 4, false, 4, 7, 0, new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 14, false, 4, 7, 0, new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 24, false, 4, 7, 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 40, true, 10, 7, 0, new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 7, false, 7, 8, 0, new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 18, false, 8, 6, 0, new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 17, false, 7, 8, 0, new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 37, false, 7, 8, 0, new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 8, false, 8, 9, 0, new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 20, true, 10, 9, 0, new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 28, false, 8, 9, 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 38, false, 8, 9, 0, new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, true, 10, 10, 0, new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 11, false, 1, 10, 0, new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 30, true, 10, 8, 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 9, true, 9, 6, 0, new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 36, false, 6, 5, 0, new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 26, false, 6, 5, 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 19, true, 9, 1, 0, new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 21, false, 1, 1, 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 31, false, 1, 1, 0, new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 2, false, 2, 2, 0, new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 12, false, 2, 2, 0, new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 29, true, 9, 2, 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 32, false, 2, 2, 0, new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 5, false, 5, 3, 0, new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 15, false, 5, 3, 0, new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 25, false, 5, 3, 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 39, true, 9, 3, 0, new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 3, false, 3, 4, 0, new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 13, false, 3, 4, 0, new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 23, false, 3, 4, 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 33, false, 3, 4, 0, new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 6, false, 6, 5, 0, new DateTime(2020, 6, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 16, false, 6, 5, 0, new DateTime(2020, 6, 15, 22, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 22, false, 2, 10, 0, new DateTime(2020, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 35, false, 5, 10, 0, new DateTime(2020, 6, 16, 2, 0, 0, 0, DateTimeKind.Unspecified), 20 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Theatres_MovieId",
                table: "Theatres",
                column: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_CustomerId",
                table: "Tickets",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TheatreId",
                table: "Tickets",
                column: "TheatreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Theatres");

            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
