using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asdsaa3218 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 12, 37, 5, 50, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 12, 37, 5, 50, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 12, 95, 101, 210, 198, 132, 24, 201, 92, 128, 123, 28, 93, 172, 218, 129, 215, 186, 237, 136, 209, 85, 169, 109, 169, 237, 65, 88, 84, 209, 161, 57, 28, 237, 154, 169, 236, 51, 73, 245, 166, 36, 130, 64, 36, 89, 81, 43, 54, 188, 118, 83, 121, 0, 212, 252, 25, 32, 241, 255, 54, 124, 48 }, new byte[] { 105, 11, 166, 212, 3, 125, 28, 137, 173, 197, 87, 254, 66, 84, 66, 109, 64, 112, 11, 44, 238, 48, 146, 242, 141, 46, 38, 223, 169, 190, 245, 250, 139, 200, 30, 56, 46, 8, 2, 153, 6, 178, 143, 174, 253, 57, 109, 126, 122, 198, 199, 21, 100, 99, 91, 209, 119, 178, 230, 170, 228, 36, 162, 47, 5, 74, 101, 18, 37, 190, 20, 154, 88, 254, 46, 201, 39, 85, 8, 164, 42, 243, 89, 252, 181, 248, 35, 144, 68, 182, 76, 175, 39, 181, 161, 53, 155, 162, 10, 99, 99, 28, 99, 139, 218, 181, 28, 58, 109, 139, 14, 173, 24, 16, 138, 206, 38, 186, 180, 121, 110, 163, 218, 170, 54, 43, 185, 248 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 12, 1, 4, 510, DateTimeKind.Local).AddTicks(3420));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 12, 1, 4, 510, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 108, 24, 133, 38, 240, 205, 161, 21, 22, 165, 212, 108, 231, 188, 69, 201, 188, 10, 117, 101, 157, 235, 223, 184, 108, 11, 70, 22, 17, 121, 152, 60, 124, 39, 164, 99, 31, 111, 219, 81, 228, 187, 76, 240, 74, 236, 42, 125, 54, 36, 163, 213, 250, 60, 200, 103, 235, 136, 191, 87, 39, 103, 230, 9 }, new byte[] { 14, 168, 75, 226, 144, 251, 171, 129, 233, 27, 204, 180, 167, 113, 179, 197, 91, 145, 97, 219, 229, 235, 85, 175, 108, 176, 48, 132, 140, 18, 138, 250, 124, 209, 65, 4, 235, 59, 170, 230, 140, 138, 120, 214, 126, 176, 225, 157, 8, 8, 168, 186, 161, 197, 204, 231, 150, 20, 74, 253, 151, 36, 164, 123, 186, 230, 82, 50, 243, 89, 111, 127, 107, 87, 152, 134, 161, 165, 37, 215, 220, 92, 224, 248, 153, 4, 137, 72, 224, 160, 252, 217, 164, 80, 185, 242, 252, 22, 154, 42, 125, 44, 188, 43, 67, 102, 247, 102, 238, 99, 24, 52, 48, 230, 8, 160, 48, 249, 131, 147, 28, 226, 104, 37, 55, 157, 212, 79 } });
        }
    }
}
