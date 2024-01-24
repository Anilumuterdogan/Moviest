using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Mig31 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImgagePath",
                table: "Movies",
                newName: "ImagePath");

            migrationBuilder.RenameColumn(
                name: "ImgagePath",
                table: "Casts",
                newName: "ImagePath");

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
                values: new object[] { "00cc8a76-dfe8-48c2-afb9-de13e2603f1a", new DateTime(2024, 1, 24, 17, 20, 17, 925, DateTimeKind.Utc).AddTicks(1229), "AQAAAAIAAYagAAAAELWMGbBHQv5OpW1nT1wmcRv+bkaF/LkwZpuNJIZovb3FpAhMdyEeBYOH68TDcg/5UQ==", "0b5b6c29-3372-40f2-9a53-0f13af766fc3" });

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(99));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(103));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(238));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9939));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9946));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9947));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9962));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9963));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9964));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9966));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9968));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9970));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9972));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9974));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 987, DateTimeKind.Utc).AddTicks(9975));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(294));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 4, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(297));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 6, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(301));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 8, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(302));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(304));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 10, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(305));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 11, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(306));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 13, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(308));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(542));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(61));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 20, 17, 988, DateTimeKind.Utc).AddTicks(64));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Movies",
                newName: "ImgagePath");

            migrationBuilder.RenameColumn(
                name: "ImagePath",
                table: "Casts",
                newName: "ImgagePath");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "a17e6cae-73af-460e-a660-012dfdba6004");

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
