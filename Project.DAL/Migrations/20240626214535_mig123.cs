using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig123 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovieLists",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieLists", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MovieLists_AspNetUsers_ID",
                        column: x => x.ID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieListJunctions",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    MovieListID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieListJunctions", x => new { x.MovieID, x.MovieListID });
                    table.ForeignKey(
                        name: "FK_MovieListJunctions_MovieLists_MovieListID",
                        column: x => x.MovieListID,
                        principalTable: "MovieLists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieListJunctions_Movies_MovieID",
                        column: x => x.MovieID,
                        principalTable: "Movies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "e8d122b7-82ed-440f-a273-d885684bcee4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4639f22b-5e50-4884-af9e-1faae216a2fa", new DateTime(2024, 6, 26, 21, 45, 34, 433, DateTimeKind.Utc).AddTicks(9074), "AQAAAAIAAYagAAAAEGDB7IDKdVvk5Gp7qbaeVOShRGK3lINf3gkBZ6RfMZQYxhe4Wa9pqvnQeao9scghoQ==", "0055bde5-d414-4207-9ca6-d08be0958af2" });

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7336));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7341));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7342));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7343));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7344));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7345));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7346));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7347));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7351));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7352));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7207));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7208));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7222));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7223));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7224));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7228));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7229));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7230));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7231));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7232));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7490));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 4, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7497));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7498));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 6, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7501));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 8, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7502));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 10, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 11, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7505));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 13, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 14, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7507));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7712));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7713));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7294));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 45, 34, 491, DateTimeKind.Utc).AddTicks(7298));

            migrationBuilder.CreateIndex(
                name: "IX_MovieListJunctions_MovieListID",
                table: "MovieListJunctions",
                column: "MovieListID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MovieListJunctions");

            migrationBuilder.DropTable(
                name: "MovieLists");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7943c6a7-91ce-409c-81db-714fbccc1ba1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7e9290d-bd5c-48d3-ac24-e328b6b1bb6d", new DateTime(2024, 1, 24, 17, 7, 54, 916, DateTimeKind.Utc).AddTicks(8139), "AQAAAAIAAYagAAAAEHG5l/qVsjNbeyHJgVAs2x5aMHxhuv1nBZ8u2hRKZapEfMYNwjl0gHelBtT5AhpCUw==", "5431058b-f0f2-43a4-b17c-c45a2201c506" });

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4742));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4747));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4748));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4749));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4750));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4752));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4753));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4902));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4903));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4906));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4907));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4908));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4909));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4574));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4584));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4586));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4587));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4600));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4607));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4609));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4958));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4963));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4964));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 4, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4966));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 6, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4969));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 8, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4972));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 10, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4973));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 11, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4974));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4975));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 13, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 14, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 37, 28, 596, DateTimeKind.Utc).AddTicks(2532));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5192));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 7, 54, 974, DateTimeKind.Utc).AddTicks(4697));
        }
    }
}
