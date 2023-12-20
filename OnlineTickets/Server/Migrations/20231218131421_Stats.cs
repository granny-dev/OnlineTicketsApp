using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineTickets.Server.Migrations
{
    /// <inheritdoc />
    public partial class Stats : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stats",
                columns: table => new
                {
                    StatsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Visits = table.Column<int>(type: "INTEGER", nullable: false),
                    LastVisit = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stats", x => x.StatsId);
                });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3655), new DateTime(2023, 12, 18, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3583), new DateTime(2023, 12, 18, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3654) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 28, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3666), new DateTime(2023, 12, 18, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3663), new DateTime(2023, 12, 21, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3665) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 1, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3673), new DateTime(2023, 12, 18, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3671), new DateTime(2023, 12, 25, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3672) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 27, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3678), new DateTime(2023, 12, 18, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3675), new DateTime(2023, 12, 20, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3677) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3682), new DateTime(2023, 12, 18, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3679), new DateTime(2023, 12, 18, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3681) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3687), new DateTime(2023, 12, 18, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3684), new DateTime(2023, 12, 19, 15, 14, 21, 28, DateTimeKind.Local).AddTicks(3686) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stats");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3864), new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3788), new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3863) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 28, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3875), new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3872), new DateTime(2023, 12, 21, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3874) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2024, 1, 1, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3883), new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3877), new DateTime(2023, 12, 25, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3882) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 27, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3911), new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3907), new DateTime(2023, 12, 20, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3909) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 25, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3916), new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3912), new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3915) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "EndDate", "SelectedDate", "StartDate" },
                values: new object[] { new DateTime(2023, 12, 26, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3922), new DateTime(2023, 12, 18, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3918), new DateTime(2023, 12, 19, 2, 54, 35, 904, DateTimeKind.Local).AddTicks(3921) });
        }
    }
}
