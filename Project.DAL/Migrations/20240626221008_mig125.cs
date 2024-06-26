using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig125 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieLists_AspNetUsers_ID",
                table: "MovieLists");

            migrationBuilder.DropTable(
                name: "MovieListJunctions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieLists",
                table: "MovieLists");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "MovieLists",
                newName: "AppUserID");

            migrationBuilder.AddColumn<int>(
                name: "MovieID",
                table: "MovieLists",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieLists",
                table: "MovieLists",
                columns: new[] { "MovieID", "AppUserID" });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "16784401-b163-45ee-b29e-3b0cbdf79538");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c9813233-ee9e-4c41-bcce-f2aa4701f6aa", new DateTime(2024, 6, 26, 22, 10, 7, 415, DateTimeKind.Utc).AddTicks(6775), "AQAAAAIAAYagAAAAEKoa+XC4p0PMttWGR2utnL4uTpBFcI/Jq4NjCBnXP67EaR14jN+L+9k1+YTL+gIc4Q==", "4db9603c-8eac-4ee0-8c92-903409f65a3b" });

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4931));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4935));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4936));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4937));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4938));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4940));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4941));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4942));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4946));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4947));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4789));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4798));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4799));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4813));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4814));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4815));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4816));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4817));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4818));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4819));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4821));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4822));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4823));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 4, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 6, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 8, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 10, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 11, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 13, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 14, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5140));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5146));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4893));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 22, 10, 7, 478, DateTimeKind.Utc).AddTicks(4897));

            migrationBuilder.CreateIndex(
                name: "IX_MovieLists_AppUserID",
                table: "MovieLists",
                column: "AppUserID");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieLists_AspNetUsers_AppUserID",
                table: "MovieLists",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MovieLists_Movies_MovieID",
                table: "MovieLists",
                column: "MovieID",
                principalTable: "Movies",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MovieLists_AspNetUsers_AppUserID",
                table: "MovieLists");

            migrationBuilder.DropForeignKey(
                name: "FK_MovieLists_Movies_MovieID",
                table: "MovieLists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MovieLists",
                table: "MovieLists");

            migrationBuilder.DropIndex(
                name: "IX_MovieLists_AppUserID",
                table: "MovieLists");

            migrationBuilder.DropColumn(
                name: "MovieID",
                table: "MovieLists");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "MovieLists",
                newName: "ID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MovieLists",
                table: "MovieLists",
                column: "ID");

            migrationBuilder.CreateTable(
                name: "MovieListJunctions",
                columns: table => new
                {
                    MovieID = table.Column<int>(type: "int", nullable: false),
                    MovieListID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                value: "cb55a677-3dd3-465c-a8ec-f53031bd63f6");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "71158e0d-213f-40e9-8d07-efbd1a16796e", new DateTime(2024, 6, 26, 21, 57, 44, 285, DateTimeKind.Utc).AddTicks(9283), "AQAAAAIAAYagAAAAEDXVTV+6iW/jczWG35+5rRXlY/JYXvCpWAC4oUUtj1zfu8wX8/Op4JyuLt8YEKxvzQ==", "ba3f87ef-a0a7-447c-acd2-5010e56179cb" });

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5871));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5876));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5877));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5879));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5880));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5881));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5882));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5883));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5884));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5991));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5735));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5736));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5747));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5750));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5751));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5752));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5753));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5754));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5756));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5757));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5758));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 4, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6043));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 6, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 8, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6047));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 10, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 11, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 13, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 14, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6237));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(6239));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5830));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 6, 26, 21, 57, 44, 345, DateTimeKind.Utc).AddTicks(5832));

            migrationBuilder.CreateIndex(
                name: "IX_MovieListJunctions_MovieListID",
                table: "MovieListJunctions",
                column: "MovieListID");

            migrationBuilder.AddForeignKey(
                name: "FK_MovieLists_AspNetUsers_ID",
                table: "MovieLists",
                column: "ID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
