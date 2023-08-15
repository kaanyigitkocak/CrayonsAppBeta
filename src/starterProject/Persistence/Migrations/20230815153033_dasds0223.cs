using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dasds0223 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 6, 42, 885, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 6, 42, 885, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 71, 199, 235, 17, 155, 159, 69, 228, 30, 145, 32, 57, 158, 212, 94, 114, 179, 5, 199, 68, 200, 11, 13, 172, 26, 19, 33, 193, 219, 26, 244, 94, 48, 133, 204, 1, 254, 247, 92, 79, 125, 97, 152, 133, 133, 237, 141, 215, 187, 142, 117, 34, 242, 88, 160, 246, 117, 247, 91, 136, 72, 111, 74, 249 }, new byte[] { 222, 238, 118, 228, 128, 114, 152, 98, 62, 87, 105, 189, 6, 51, 182, 108, 101, 165, 68, 115, 141, 22, 71, 145, 146, 243, 194, 87, 132, 52, 160, 218, 191, 173, 52, 238, 228, 246, 244, 144, 192, 100, 51, 146, 64, 69, 78, 197, 86, 100, 83, 114, 228, 34, 65, 151, 111, 146, 177, 67, 106, 190, 156, 253, 113, 145, 179, 223, 162, 149, 195, 188, 232, 35, 139, 65, 133, 187, 6, 160, 6, 130, 47, 125, 37, 44, 207, 53, 114, 9, 201, 150, 136, 112, 147, 161, 196, 108, 191, 111, 205, 134, 138, 180, 26, 174, 222, 95, 218, 129, 135, 140, 216, 153, 83, 92, 226, 107, 98, 183, 83, 23, 170, 220, 34, 122, 154, 107 } });
        }
    }
}
