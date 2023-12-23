using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace OnlineTickets.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddFieldsEmailAndPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CustomerEmail",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PaymentStatus",
                table: "Movies",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 1,
                columns: new[] { "CustomerEmail", "PaymentStatus", "SelectedDate" },
                values: new object[] { "", "", new DateTime(2023, 12, 22, 22, 35, 29, 938, DateTimeKind.Local).AddTicks(4375) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 2,
                columns: new[] { "CustomerEmail", "PaymentStatus", "SelectedDate" },
                values: new object[] { "", "", new DateTime(2023, 12, 22, 22, 35, 29, 938, DateTimeKind.Local).AddTicks(4452) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 3,
                columns: new[] { "CustomerEmail", "PaymentStatus", "SelectedDate" },
                values: new object[] { "", "", new DateTime(2023, 12, 22, 22, 35, 29, 938, DateTimeKind.Local).AddTicks(4456) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 4,
                columns: new[] { "CustomerEmail", "PaymentStatus", "SelectedDate" },
                values: new object[] { "", "", new DateTime(2023, 12, 22, 22, 35, 29, 938, DateTimeKind.Local).AddTicks(4459) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 5,
                columns: new[] { "CustomerEmail", "PaymentStatus", "SelectedDate" },
                values: new object[] { "", "", new DateTime(2023, 12, 22, 22, 35, 29, 938, DateTimeKind.Local).AddTicks(4462) });

            migrationBuilder.UpdateData(
                table: "Movies",
                keyColumn: "MovieId",
                keyValue: 6,
                columns: new[] { "CustomerEmail", "PaymentStatus", "SelectedDate" },
                values: new object[] { "", "", new DateTime(2023, 12, 22, 22, 35, 29, 938, DateTimeKind.Local).AddTicks(4465) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CustomerEmail",
                table: "Movies");

            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Movies");

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
    }
}
