using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineTickets.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusAndReserved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Reserved",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "CinemaId",
                keyValue: 1,
                column: "Capacity",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "CinemaId",
                keyValue: 3,
                column: "Capacity",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "Reserved", "SelectedDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 25, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3864), 0, new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3788), new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3863), "Available" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "Reserved", "SelectedDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 28, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3875), 0, new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3872), new DateTime(2023, 12, 21, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3874), "Available" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "Reserved", "SelectedDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2024, 1, 1, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3883), 0, new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3877), new DateTime(2023, 12, 25, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3882), "Available" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "Reserved", "SelectedDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 27, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3911), 0, new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3907), new DateTime(2023, 12, 20, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3909), "Available" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "Reserved", "SelectedDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 25, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3916), 0, new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3912), new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3915), "Available" });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "Reserved", "SelectedDate", "StartDate", "Status" },
                values: new object[] { new DateTime(2023, 12, 26, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3922), 0, new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3918), new DateTime(2023, 12, 19, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3921), "Available" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reserved",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Movies");

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "CinemaId",
                keyValue: 1,
                column: "Capacity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Cinemas",
                keyColumn: "CinemaId",
                keyValue: 3,
                column: "Capacity",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1938), new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1865), new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1937) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 28, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1953), new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1949), new DateTime(2023, 12, 21, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1951) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 1, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1958), new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1955), new DateTime(2023, 12, 25, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1957) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 27, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1963), new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1960), new DateTime(2023, 12, 20, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1962) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1969), new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1964), new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1968) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1976), new DateTime(2023, 12, 18, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1972), new DateTime(2023, 12, 19, 2, 25, 3, 465, DateTimeKind.Local).AddTicks(1974) });
        }
    }
}
