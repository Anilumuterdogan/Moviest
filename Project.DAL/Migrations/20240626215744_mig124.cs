using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class mig124 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
