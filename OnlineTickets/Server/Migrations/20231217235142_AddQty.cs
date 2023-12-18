using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineTickets.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddQty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Qty",
                table: "Movies",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "Qty", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5793), 0, new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5726), new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5792) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "Qty", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 28, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5804), 0, new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5800), new DateTime(2023, 12, 21, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5803) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "Qty", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 1, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5810), 0, new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5806), new DateTime(2023, 12, 25, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5808) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "Qty", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 27, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5815), 0, new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5811), new DateTime(2023, 12, 20, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5814) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "Qty", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5819), 0, new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5816), new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5819) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "Qty", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5825), 0, new DateTime(2023, 12, 18, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5822), new DateTime(2023, 12, 19, 1, 51, 42, 527, DateTimeKind.Local).AddTicks(5824) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Qty",
                table: "Movies");

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
    }
}
