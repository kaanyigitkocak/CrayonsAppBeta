using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dsawa232 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNumber",
                table: "Invoices",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "Invoices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 14, 20, 27, 59, 51, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 14, 20, 27, 59, 51, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 94, 248, 164, 87, 88, 204, 61, 102, 164, 40, 159, 119, 148, 7, 57, 175, 69, 205, 248, 13, 253, 223, 118, 151, 27, 153, 47, 172, 95, 35, 202, 47, 125, 158, 193, 63, 242, 179, 111, 119, 72, 2, 216, 209, 239, 244, 227, 239, 69, 162, 228, 61, 199, 18, 108, 119, 74, 21, 239, 249, 165, 16, 122, 152 }, new byte[] { 179, 13, 51, 234, 205, 43, 201, 155, 74, 147, 27, 84, 138, 5, 199, 76, 165, 154, 72, 60, 11, 211, 140, 81, 128, 245, 236, 66, 10, 63, 213, 46, 4, 96, 126, 26, 8, 199, 19, 244, 201, 200, 251, 12, 37, 109, 150, 229, 195, 225, 54, 14, 172, 148, 122, 59, 64, 41, 16, 185, 101, 249, 146, 39, 49, 162, 217, 169, 53, 3, 176, 40, 245, 179, 202, 130, 54, 116, 130, 83, 205, 112, 151, 57, 254, 185, 127, 148, 239, 7, 78, 137, 128, 234, 221, 53, 202, 51, 168, 6, 120, 133, 36, 50, 128, 113, 144, 211, 54, 144, 42, 187, 2, 78, 116, 42, 252, 142, 142, 225, 240, 49, 156, 227, 23, 116, 201, 66 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNumber",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 14, 20, 26, 44, 867, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 14, 20, 26, 44, 867, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 110, 175, 66, 41, 42, 95, 153, 179, 170, 95, 100, 23, 187, 240, 223, 87, 117, 174, 97, 20, 183, 63, 240, 102, 20, 151, 194, 162, 37, 47, 72, 113, 223, 208, 70, 215, 205, 15, 232, 53, 45, 76, 250, 65, 252, 225, 216, 57, 42, 111, 181, 130, 69, 199, 199, 238, 24, 32, 87, 244, 229, 35, 224, 54 }, new byte[] { 75, 193, 161, 130, 40, 96, 24, 60, 128, 245, 25, 130, 153, 11, 38, 230, 238, 91, 174, 104, 6, 235, 208, 152, 244, 202, 222, 220, 56, 217, 110, 172, 233, 165, 72, 246, 176, 96, 100, 97, 223, 201, 11, 225, 115, 16, 158, 34, 87, 29, 11, 28, 245, 130, 74, 63, 231, 207, 119, 235, 76, 227, 255, 71, 9, 221, 199, 162, 208, 223, 116, 161, 14, 120, 23, 186, 218, 244, 66, 184, 97, 179, 238, 85, 76, 205, 249, 176, 177, 0, 6, 77, 159, 2, 24, 202, 118, 119, 44, 59, 138, 104, 168, 0, 253, 108, 31, 203, 109, 154, 152, 156, 43, 236, 221, 67, 227, 2, 113, 107, 165, 168, 145, 66, 112, 116, 93, 37 } });
        }
    }
}
