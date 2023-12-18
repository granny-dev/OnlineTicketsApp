using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineTickets.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddPlaceId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlaceId",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "PlaceId", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1938), 0, new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1865), new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "PlaceId", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 28, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1953), 0, new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1949), new DateTime(2023, 12, 21, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "PlaceId", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 1, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1958), 0, new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1955), new DateTime(2023, 12, 25, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "PlaceId", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 27, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1963), 0, new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1960), new DateTime(2023, 12, 20, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "PlaceId", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1969), 0, new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1964), new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "PlaceId", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1976), 0, new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1972), new DateTime(2023, 12, 19, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1974) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PlaceId",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5793), new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5726), new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 28, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5804), new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 12, 21, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 1, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5810), new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5806), new DateTime(2023, 12, 25, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 27, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5815), new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 12, 20, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5819), new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5825), new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 12, 19, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5824) });
        }
    }
}
