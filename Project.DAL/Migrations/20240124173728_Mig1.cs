using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Casts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Casts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenreName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MovieName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VideoPath = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Profiles_AspNetUsers_ID",
                        column: x => x.ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieCasts",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    CastID = table.Column<int>(type: "int", nullable: false),
                    NameInMovie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieCasts", x => new { x.MovieID, x.CastID });
                    table.ForeignKey(
                        name: "FK_MovieCasts_Casts_CastID",
                        column: x => x.CastID,
                        principalTable: "Casts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieCasts_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieGenres",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    GenreID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieGenres", x => new { x.MovieID, x.GenreID });
                    table.ForeignKey(
                        name: "FK_MovieGenres_Genres_GenreID",
                        column: x => x.GenreID,
                        principalTable: "Genres",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieGenres_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 1, "90688f73-3467-49c9-a48f-1cafd0770f58", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "c730e72a-3ce3-4c55-908a-39852a44cd96", new DateTime(2024, 1, 24, 17, 37, 28, 539, DateTimeKind.Utc).AddTicks(983), null, "aost@gmail.com", true, false, null, null, "AOST@GMAIL.COM", "AOST", "AQAAAAIAAYagAAAAELiK49KHBT5RkF+invNeCWpZP2NjoRmtzqxvcMwXJWgGIC3KkvWPkZ/3D0d8CLurkg==", null, false, "4015d706-2f11-4058-8e61-0d63157a8353", 0, false, "aost" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Description", "FirstName", "ImagePath", "LastName", "ModifiedDate", "Status", "VideoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2467), null, null, "Christian", null, "Bale", null, 0, null },
                    { 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2470), null, null, "Christopher", null, "Nolen", null, 0, null },
                    { 3, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2471), null, null, "Heath", null, "Ledger", null, 0, null },
                    { 4, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2472), null, null, "Aaron", null, "Eckhart", null, 0, null },
                    { 5, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2473), null, null, "Michael", null, "Caine", null, 0, null },
                    { 6, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2474), null, null, "Morgon", null, "Freeman", null, 0, null },
                    { 7, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2475), null, null, "Cillian", null, "Murphy", null, 0, null },
                    { 8, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2475), null, null, "Justin", null, "Theroux", null, 0, null },
                    { 9, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2476), null, null, "Josh", null, "Lucas", null, 0, null },
                    { 10, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2477), null, null, "Reese", null, "Witherspoon", null, 0, null },
                    { 11, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2478), null, null, "Samantha", null, "Mathis", null, 0, null },
                    { 12, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2479), null, null, "Jared", null, "Leto", null, 0, null },
                    { 13, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2480), null, null, "Willem", null, "Dafoe", null, 0, null },
                    { 14, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2480), null, null, "Mary", null, "Harron", null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "GenreName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2289), null, "Drama", null, 0 },
                    { 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2296), null, "Action", null, 0 },
                    { 3, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2297), null, "Adventure", null, 0 },
                    { 4, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2298), null, "Animation", null, 0 },
                    { 5, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2299), null, "Biography", null, 0 },
                    { 6, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2306), null, "Comedy", null, 0 },
                    { 7, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2306), null, "Crime", null, 0 },
                    { 8, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2307), null, "Documentary", null, 0 },
                    { 9, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2308), null, "Family", null, 0 },
                    { 10, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2310), null, "Fantasy", null, 0 },
                    { 11, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2311), null, "History", null, 0 },
                    { 12, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2312), null, "Horror", null, 0 },
                    { 13, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2367), null, "Mystery", null, 0 },
                    { 14, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2368), null, "Romance", null, 0 },
                    { 15, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2369), null, "War", null, 0 },
                    { 16, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2370), null, "Western", null, 0 },
                    { 17, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2371), null, "Sci-Fi", null, 0 },
                    { 18, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2372), null, "Sport", null, 0 },
                    { 19, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2373), null, "Thriller", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Description", "ImagePath", "ModifiedDate", "MovieName", "Status", "VideoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2434), null, null, null, null, "The Dark Knight", 0, null },
                    { 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2437), null, null, null, null, "American Psycho", 0, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "MovieCasts",
                columns: new[] { "CastID", "MovieID", "CreatedDate", "DeletedDate", "ModifiedDate", "NameInMovie", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2517), null, null, "Bruce Wayne", 0 },
                    { 2, 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2521), null, null, null, 0 },
                    { 3, 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2521), null, null, "Joker", 0 },
                    { 4, 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2522), null, null, "Harvey Dent", 0 },
                    { 5, 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2523), null, null, "Alfred", 0 },
                    { 6, 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2524), null, null, "Lucius Fox", 0 },
                    { 7, 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2525), null, null, "Scarecrow", 0 },
                    { 1, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2526), null, null, "Patrick Bateman", 0 },
                    { 8, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2527), null, null, "Timothy Bryce", 0 },
                    { 9, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2528), null, null, "Craig McDermott", 0 },
                    { 10, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2529), null, null, "Evelyn Williams", 0 },
                    { 11, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2530), null, null, "Courtney Rawlinson", 0 },
                    { 12, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2531), null, null, "Paul Allen", 0 },
                    { 13, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2531), null, null, "Donald Kimball", 0 },
                    { 14, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2532), null, null, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "GenreID", "MovieID", "CreatedDate", "DeletedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2645), null, null, 0 },
                    { 2, 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2648), null, null, 0 },
                    { 7, 1, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2648), null, null, 0 },
                    { 1, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2650), null, null, 0 },
                    { 7, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2649), null, null, 0 },
                    { 12, 2, new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2651), null, null, 0 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_MovieCasts_CastID",
                table: "MovieCasts",
                column: "CastID");

            migrationBuilder.CreateIndex(
                name: "IX_MovieGenres_GenreID",
                table: "MovieGenres",
                column: "GenreID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "MovieCasts");

            migrationBuilder.DropTable(
                name: "MovieGenres");

            migrationBuilder.DropTable(
                name: "Profiles");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Casts");

            migrationBuilder.DropTable(
                name: "Genres");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
