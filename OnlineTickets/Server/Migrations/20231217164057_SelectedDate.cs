using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineTickets.Server.Migrations
{
    /// <inheritdoc />
    public partial class SelectedDate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1134), new DateTime(2023, 12, 17, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1050), new DateTime(2023, 12, 17, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 27, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1146), new DateTime(2023, 12, 17, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1141), new DateTime(2023, 12, 20, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 31, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1151), new DateTime(2023, 12, 17, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1148), new DateTime(2023, 12, 24, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1150) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1156), new DateTime(2023, 12, 17, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1153), new DateTime(2023, 12, 19, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1162), new DateTime(2023, 12, 17, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1158), new DateTime(2023, 12, 17, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1160) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1168), new DateTime(2023, 12, 17, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1164), new DateTime(2023, 12, 18, 18, 40, 57, 711, DateTimeKind.Local).AddTicks(1166) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8548), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 17, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8428) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 27, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8559), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 20, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 31, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8564), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 24, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8563) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8568), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 19, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 24, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8572), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 17, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8576), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 12, 18, 18, 39, 9, 495, DateTimeKind.Local).AddTicks(8575) });
        }
    }
}
