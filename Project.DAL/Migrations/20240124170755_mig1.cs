using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig1 : Migration
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
                    ImgagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    ImgagePath = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                values: new object[] { 1, "a17e6cae-73af-460e-a660-012dfdba6004", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "ModifiedDate", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "c7e9290d-bd5c-48d3-ac24-e328b6b1bb6d", new DateTime(2024, 1, 24, 17, 7, 54, 916, DateTimeKind.Utc).AddTicks(8139), null, "aost@gmail.com", true, false, null, null, "AOST@GMAIL.COM", "AOST", "AQAAAAIAAYagAAAAEHG5l/qVsjNbeyHJgVAs2x5aMHxhuv1nBZ8u2hRKZapEfMYNwjl0gHelBtT5AhpCUw==", null, false, "5431058b-f0f2-43a4-b17c-c45a2201c506", 0, false, "aost" });

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Description", "FirstName", "ImgagePath", "LastName", "ModifiedDate", "Status", "VideoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4742), null, null, "Christian", null, "Bale", null, 0, null },
                    { 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4747), null, null, "Christopher", null, "Nolen", null, 0, null },
                    { 3, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4748), null, null, "Heath", null, "Ledger", null, 0, null },
                    { 4, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4749), null, null, "Aaron", null, "Eckhart", null, 0, null },
                    { 5, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4750), null, null, "Michael", null, "Caine", null, 0, null },
                    { 6, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4752), null, null, "Morgon", null, "Freeman", null, 0, null },
                    { 7, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4753), null, null, "Cillian", null, "Murphy", null, 0, null },
                    { 8, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4902), null, null, "Justin", null, "Theroux", null, 0, null },
                    { 9, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4903), null, null, "Josh", null, "Lucas", null, 0, null },
                    { 10, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4906), null, null, "Reese", null, "Witherspoon", null, 0, null },
                    { 11, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4907), null, null, "Samantha", null, "Mathis", null, 0, null },
                    { 12, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4908), null, null, "Jared", null, "Leto", null, 0, null },
                    { 13, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4909), null, null, "Willem", null, "Dafoe", null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "GenreName", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4574), null, "Drama", null, 0 },
                    { 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4584), null, "Action", null, 0 },
                    { 3, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4586), null, "Adventure", null, 0 },
                    { 4, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4587), null, "Animation", null, 0 },
                    { 5, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4588), null, "Biography", null, 0 },
                    { 6, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4599), null, "Comedy", null, 0 },
                    { 7, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4600), null, "Crime", null, 0 },
                    { 8, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4601), null, "Documentary", null, 0 },
                    { 9, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4602), null, "Family", null, 0 },
                    { 10, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4606), null, "Fantasy", null, 0 },
                    { 11, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4606), null, "History", null, 0 },
                    { 12, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4607), null, "Horror", null, 0 },
                    { 13, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4608), null, "Mystery", null, 0 },
                    { 14, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4609), null, "Romance", null, 0 },
                    { 15, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4610), null, "War", null, 0 },
                    { 16, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4611), null, "Western", null, 0 },
                    { 17, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4611), null, "Sci-Fi", null, 0 },
                    { 18, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4613), null, "Sport", null, 0 },
                    { 19, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4614), null, "Thriller", null, 0 }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Description", "ImgagePath", "ModifiedDate", "MovieName", "Status", "VideoPath" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4693), null, null, null, null, "The Dark Knight", 0, null },
                    { 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4697), null, null, null, null, "American Psycho", 0, null }
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
                    { 1, 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4958), null, null, "Bruce Wayne", 0 },
                    { 2, 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4963), null, null, null, 0 },
                    { 3, 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4964), null, null, "Joker", 0 },
                    { 4, 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4965), null, null, "Harvey Dent", 0 },
                    { 5, 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4966), null, null, "Alfred", 0 },
                    { 6, 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4968), null, null, "Lucius Fox", 0 },
                    { 7, 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4969), null, null, "Scarecrow", 0 },
                    { 1, 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4970), null, null, "Patrick Bateman", 0 },
                    { 8, 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4971), null, null, "Timothy Bryce", 0 },
                    { 9, 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4972), null, null, "Craig McDermott", 0 },
                    { 10, 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4973), null, null, "Evelyn Williams", 0 },
                    { 11, 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4974), null, null, "Courtney Rawlinson", 0 },
                    { 12, 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4975), null, null, "Paul Allen", 0 },
                    { 13, 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4976), null, null, "Donald Kimball", 0 }
                });

            migrationBuilder.InsertData(
                table: "MovieGenres",
                columns: new[] { "GenreID", "MovieID", "CreatedDate", "DeletedDate", "ModifiedDate", "Status" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5192), null, null, 0 },
                    { 2, 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5197), null, null, 0 },
                    { 7, 1, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5198), null, null, 0 },
                    { 1, 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5199), null, null, 0 },
                    { 7, 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5199), null, null, 0 },
                    { 12, 2, new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5201), null, null, 0 }
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
