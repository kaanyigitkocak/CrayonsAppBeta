using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asdwe3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 11, 12, 21, 231, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 11, 12, 21, 231, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 197, 124, 130, 30, 221, 111, 84, 82, 202, 223, 61, 134, 52, 228, 192, 78, 189, 114, 136, 61, 26, 231, 141, 100, 39, 192, 64, 140, 223, 124, 185, 67, 30, 163, 189, 84, 11, 68, 190, 41, 122, 194, 12, 220, 248, 84, 182, 32, 255, 188, 127, 28, 46, 66, 7, 113, 194, 32, 0, 167, 179, 85, 170, 235 }, new byte[] { 245, 137, 41, 95, 122, 156, 67, 147, 178, 34, 211, 189, 228, 82, 25, 183, 18, 49, 191, 44, 40, 250, 65, 142, 219, 112, 1, 10, 11, 52, 242, 231, 38, 65, 11, 31, 112, 125, 27, 52, 121, 24, 207, 162, 212, 220, 51, 14, 98, 185, 100, 155, 153, 220, 121, 229, 61, 210, 94, 22, 246, 129, 231, 48, 0, 117, 180, 233, 76, 184, 26, 241, 36, 148, 78, 56, 179, 54, 59, 234, 172, 212, 126, 212, 192, 51, 114, 21, 1, 242, 43, 49, 116, 57, 185, 153, 116, 166, 210, 115, 112, 124, 89, 252, 224, 87, 50, 65, 131, 162, 152, 50, 3, 13, 1, 60, 121, 234, 222, 71, 172, 57, 48, 191, 159, 47, 10, 10 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 11, 10, 51, 11, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 11, 10, 51, 11, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 162, 243, 209, 235, 120, 116, 36, 199, 99, 214, 145, 245, 235, 77, 29, 14, 28, 42, 52, 154, 39, 33, 244, 8, 34, 116, 88, 27, 135, 141, 177, 116, 209, 199, 128, 109, 31, 177, 142, 135, 243, 53, 80, 217, 65, 79, 192, 50, 254, 54, 185, 107, 128, 155, 171, 88, 209, 75, 5, 252, 70, 228, 24, 227 }, new byte[] { 43, 251, 169, 1, 12, 42, 44, 159, 129, 192, 11, 89, 117, 157, 245, 196, 42, 42, 175, 21, 50, 205, 201, 37, 47, 227, 185, 188, 23, 37, 77, 110, 208, 7, 111, 70, 14, 153, 40, 122, 249, 168, 248, 135, 234, 211, 9, 110, 183, 242, 209, 49, 11, 189, 165, 7, 73, 236, 246, 132, 89, 35, 50, 111, 216, 112, 4, 141, 197, 58, 148, 233, 0, 236, 88, 223, 154, 148, 75, 121, 144, 239, 159, 208, 168, 71, 213, 60, 161, 248, 62, 56, 161, 27, 167, 241, 8, 43, 168, 249, 188, 136, 168, 134, 129, 230, 147, 247, 112, 190, 255, 232, 29, 151, 145, 59, 66, 104, 11, 87, 133, 29, 248, 197, 188, 129, 118, 138 } });
        }
    }
}
