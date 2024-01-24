using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.DAL.Migrations
{
    /// <inheritdoc />
    public partial class addmigrationMigA : Migration
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
                value: "c15ec1b0-81c8-4952-aba3-11e3442f5ca9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "CreatedDate", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed887745-b019-437a-8b60-05ae503c4f69", new DateTime(2024, 1, 24, 17, 32, 6, 959, DateTimeKind.Utc).AddTicks(8148), "AQAAAAIAAYagAAAAEJKeRApTRWF2PVu41dxSfkPgsETgK6AwDnuodk2ul54kACpFy06WLRRqQzusHCscfw==", "d7d59b1e-f8a9-4df6-b3de-010a788d1449" });

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2830));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2832));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2833));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2835));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2836));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2840));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2841));

            migrationBuilder.UpdateData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2842));

            migrationBuilder.InsertData(
                table: "Casts",
                columns: new[] { "ID", "CreatedDate", "DeletedDate", "Description", "FirstName", "ImagePath", "LastName", "ModifiedDate", "Status", "VideoPath" },
                values: new object[] { 14, new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2843), null, null, "Mary", null, "Harron", null, 0, null });

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2641));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "Genres",
                keyColumn: "ID",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2874));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 3, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2878));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 4, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 5, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2880));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 6, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2882));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 8, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 9, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 10, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2885));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 11, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2886));

            migrationBuilder.UpdateData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 13, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2887));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(3017));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 2, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 1 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(3021));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 1, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 7, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(3022));

            migrationBuilder.UpdateData(
                table: "MovieGenres",
                keyColumns: new[] { "GenreID", "MovieID" },
                keyValues: new object[] { 12, 2 },
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(3023));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "ID",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2798));

            migrationBuilder.InsertData(
                table: "MovieCasts",
                columns: new[] { "CastID", "MovieID", "CreatedDate", "DeletedDate", "ModifiedDate", "NameInMovie", "Status" },
                values: new object[] { 14, 2, new DateTime(2024, 1, 24, 17, 32, 7, 15, DateTimeKind.Utc).AddTicks(2888), null, null, null, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MovieCasts",
                keyColumns: new[] { "CastID", "MovieID" },
                keyValues: new object[] { 14, 2 });

            migrationBuilder.DeleteData(
                table: "Casts",
                keyColumn: "ID",
                keyValue: 14);

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
