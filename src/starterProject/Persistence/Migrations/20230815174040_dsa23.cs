using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dsa23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 20, 40, 40, 281, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 20, 40, 40, 281, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 96, 223, 166, 194, 8, 17, 202, 239, 36, 129, 229, 217, 231, 188, 219, 114, 209, 86, 241, 212, 13, 94, 20, 15, 62, 53, 92, 236, 136, 196, 14, 134, 141, 189, 69, 126, 78, 140, 84, 133, 168, 76, 61, 248, 94, 142, 27, 206, 203, 215, 246, 243, 180, 199, 249, 100, 1, 55, 35, 215, 37, 20, 178, 149 }, new byte[] { 244, 143, 46, 113, 237, 186, 41, 222, 30, 115, 64, 229, 68, 103, 25, 181, 102, 127, 117, 23, 4, 180, 153, 136, 62, 137, 98, 226, 251, 132, 104, 58, 231, 167, 60, 204, 213, 108, 185, 29, 172, 8, 46, 54, 217, 130, 53, 33, 185, 20, 165, 18, 143, 69, 253, 100, 122, 61, 90, 232, 153, 233, 91, 232, 103, 162, 125, 252, 71, 166, 119, 221, 235, 234, 241, 166, 103, 239, 174, 116, 214, 193, 184, 64, 207, 175, 54, 129, 83, 195, 133, 51, 3, 187, 126, 46, 83, 13, 192, 107, 6, 188, 212, 153, 194, 12, 21, 88, 121, 208, 30, 215, 180, 30, 138, 14, 234, 210, 24, 105, 239, 3, 187, 199, 254, 124, 143, 224 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 30, 33, 153, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 30, 33, 153, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 219, 127, 172, 138, 21, 31, 17, 36, 168, 170, 36, 205, 226, 77, 215, 191, 184, 213, 122, 48, 44, 70, 50, 206, 6, 254, 44, 167, 203, 153, 252, 102, 75, 148, 190, 130, 234, 146, 45, 98, 109, 35, 152, 151, 3, 213, 132, 59, 15, 27, 30, 50, 3, 105, 85, 196, 237, 196, 199, 74, 243, 76, 102, 227 }, new byte[] { 87, 93, 27, 208, 239, 160, 15, 77, 80, 133, 218, 193, 59, 120, 72, 29, 170, 130, 8, 136, 149, 180, 159, 204, 118, 82, 33, 16, 211, 84, 56, 62, 220, 89, 176, 91, 97, 26, 36, 150, 112, 2, 138, 140, 169, 134, 177, 247, 3, 163, 84, 194, 233, 193, 109, 189, 123, 65, 33, 34, 97, 14, 223, 203, 64, 109, 240, 205, 195, 31, 38, 99, 105, 32, 12, 177, 122, 47, 154, 65, 44, 26, 113, 205, 138, 239, 170, 137, 182, 37, 115, 151, 136, 221, 219, 82, 79, 82, 110, 27, 115, 112, 57, 136, 139, 141, 228, 246, 26, 17, 228, 81, 18, 90, 65, 5, 71, 100, 204, 176, 5, 255, 35, 89, 134, 112, 119, 173 } });
        }
    }
}
