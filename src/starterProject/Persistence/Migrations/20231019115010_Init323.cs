using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init323 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 14, 50, 10, 503, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 14, 50, 10, 503, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 109, 99, 135, 255, 160, 232, 32, 86, 41, 40, 65, 85, 128, 96, 199, 67, 141, 38, 68, 0, 55, 241, 103, 101, 1, 255, 227, 159, 119, 227, 197, 131, 227, 105, 190, 80, 44, 243, 91, 183, 91, 37, 19, 197, 35, 90, 166, 227, 208, 118, 4, 167, 134, 12, 131, 26, 102, 13, 192, 129, 118, 222, 22, 163 }, new byte[] { 211, 207, 240, 197, 243, 97, 1, 82, 29, 94, 124, 209, 239, 237, 248, 12, 171, 143, 65, 180, 102, 5, 42, 151, 64, 229, 134, 31, 120, 87, 90, 190, 93, 199, 12, 243, 112, 26, 119, 69, 91, 225, 182, 3, 224, 247, 57, 109, 5, 231, 102, 37, 124, 184, 124, 40, 139, 97, 136, 14, 86, 5, 206, 188, 108, 75, 196, 161, 135, 97, 52, 38, 2, 6, 147, 6, 57, 78, 98, 222, 242, 182, 97, 78, 57, 80, 67, 124, 113, 135, 99, 206, 73, 236, 191, 16, 142, 41, 15, 39, 179, 192, 166, 29, 181, 151, 237, 79, 55, 35, 29, 53, 73, 236, 182, 242, 215, 127, 23, 13, 47, 173, 254, 15, 125, 223, 163, 251 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 14, 44, 43, 600, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 10, 19, 14, 44, 43, 600, DateTimeKind.Local).AddTicks(7120));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 191, 112, 0, 43, 152, 80, 176, 92, 74, 184, 37, 23, 241, 248, 248, 216, 175, 41, 93, 214, 26, 210, 172, 163, 178, 196, 94, 61, 114, 214, 175, 28, 37, 132, 102, 165, 104, 222, 163, 148, 68, 133, 254, 89, 87, 34, 29, 45, 205, 209, 177, 30, 198, 46, 39, 202, 222, 6, 232, 206, 240, 234, 102, 213 }, new byte[] { 118, 26, 38, 226, 163, 8, 113, 117, 45, 139, 162, 70, 110, 14, 157, 81, 29, 186, 155, 239, 72, 188, 130, 211, 94, 201, 167, 147, 245, 202, 89, 100, 72, 84, 163, 71, 249, 156, 220, 31, 38, 4, 172, 202, 91, 2, 196, 142, 15, 10, 192, 43, 156, 19, 141, 95, 163, 225, 157, 197, 224, 79, 198, 50, 163, 217, 210, 66, 212, 206, 249, 143, 150, 247, 93, 22, 53, 81, 243, 154, 247, 127, 141, 201, 77, 139, 187, 251, 195, 152, 251, 203, 164, 239, 237, 216, 231, 145, 19, 132, 163, 86, 254, 33, 251, 92, 89, 185, 137, 18, 186, 116, 213, 31, 91, 106, 161, 220, 20, 157, 140, 88, 64, 126, 138, 181, 13, 192 } });
        }
    }
}
