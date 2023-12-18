using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OnlineTickets.Server.Migrations
{
    /// <inheritdoc />
    public partial class Places : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MoviePlace",
                columns: new[] { "MoviesMovieId", "PlacesPlaceId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 1 },
                    { 4, 1 },
                    { 5, 1 },
                    { 6, 1 }
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2116), new DateTime(2023, 12, 17, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2058) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 27, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2128), new DateTime(2023, 12, 20, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2126) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 31, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2133), new DateTime(2023, 12, 24, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2132) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2138), new DateTime(2023, 12, 19, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2137) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2142), new DateTime(2023, 12, 17, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2141) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2147), new DateTime(2023, 12, 18, 14, 47, 58, 464, DateTimeKind.Local).AddTicks(2146) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MoviePlace",
                keyColumns: new[] { "MoviesMovieId", "PlacesPlaceId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MoviePlace",
                keyColumns: new[] { "MoviesMovieId", "PlacesPlaceId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "MoviePlace",
                keyColumns: new[] { "MoviesMovieId", "PlacesPlaceId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "MoviePlace",
                keyColumns: new[] { "MoviesMovieId", "PlacesPlaceId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "MoviePlace",
                keyColumns: new[] { "MoviesMovieId", "PlacesPlaceId" },
                keyValues: new object[] { 5, 1 });

            migrationBuilder.DeleteData(
                table: "MoviePlace",
                keyColumns: new[] { "MoviesMovieId", "PlacesPlaceId" },
                keyValues: new object[] { 6, 1 });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4629), new DateTime(2023, 12, 17, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4566) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 27, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4639), new DateTime(2023, 12, 20, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4637) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 31, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4642), new DateTime(2023, 12, 24, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4641) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4646), new DateTime(2023, 12, 19, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4645) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4650), new DateTime(2023, 12, 17, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4649) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4654), new DateTime(2023, 12, 18, 14, 42, 5, 939, DateTimeKind.Local).AddTicks(4653) });
        }
    }
}
