using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineTickets.Server.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5749));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5828));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5835));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5839));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 36, 6, 132, DateTimeKind.Local).AddTicks(5842));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 7, 33, 805, DateTimeKind.Local).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 7, 33, 805, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 7, 33, 805, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 7, 33, 805, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 7, 33, 805, DateTimeKind.Local).AddTicks(2637));

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                column: "SelectedDate",
                value: new DateTime(2023, 12, 22, 17, 7, 33, 805, DateTimeKind.Local).AddTicks(2641));
        }
    }
}
