using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dasds022 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 6, 1, 41, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 6, 1, 41, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 99, 125, 84, 29, 35, 152, 79, 4, 96, 165, 54, 4, 219, 161, 97, 41, 177, 13, 165, 132, 178, 156, 163, 174, 10, 211, 225, 153, 229, 171, 92, 146, 62, 51, 43, 90, 148, 238, 57, 134, 190, 74, 159, 108, 4, 155, 96, 217, 88, 214, 222, 21, 30, 113, 147, 145, 235, 66, 247, 151, 151, 193, 66, 107 }, new byte[] { 117, 81, 226, 202, 176, 111, 212, 3, 123, 118, 63, 112, 97, 175, 126, 128, 110, 40, 212, 122, 205, 201, 238, 68, 65, 168, 144, 215, 78, 187, 138, 113, 96, 243, 136, 58, 167, 209, 106, 163, 232, 15, 31, 209, 44, 144, 164, 184, 252, 56, 104, 26, 43, 30, 36, 175, 107, 150, 75, 175, 151, 124, 215, 102, 196, 200, 46, 65, 22, 81, 85, 32, 187, 33, 123, 252, 236, 181, 54, 163, 13, 145, 6, 252, 57, 137, 142, 83, 93, 14, 100, 46, 8, 87, 96, 120, 200, 14, 102, 13, 64, 97, 128, 32, 235, 128, 143, 201, 14, 128, 14, 89, 42, 215, 88, 194, 135, 214, 26, 3, 136, 90, 201, 102, 243, 72, 152, 40 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 4, 18, 931, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 4, 18, 931, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 242, 251, 212, 100, 129, 78, 53, 231, 43, 187, 221, 52, 198, 233, 179, 29, 95, 167, 37, 239, 57, 219, 206, 4, 92, 148, 178, 250, 172, 203, 181, 71, 199, 111, 141, 144, 230, 68, 138, 212, 38, 234, 231, 110, 176, 201, 63, 246, 155, 225, 46, 139, 136, 166, 155, 253, 196, 113, 93, 46, 90, 211, 16 }, new byte[] { 43, 226, 251, 187, 248, 160, 175, 168, 217, 134, 22, 159, 120, 161, 27, 97, 34, 99, 61, 193, 236, 98, 82, 33, 28, 246, 215, 252, 13, 255, 188, 214, 30, 176, 216, 171, 205, 43, 79, 162, 131, 230, 69, 77, 67, 91, 209, 37, 235, 45, 155, 146, 129, 134, 209, 225, 72, 33, 29, 143, 130, 6, 28, 25, 76, 46, 160, 32, 102, 91, 89, 28, 251, 78, 18, 88, 145, 245, 158, 149, 223, 86, 26, 15, 41, 176, 18, 85, 120, 231, 5, 211, 239, 25, 118, 250, 122, 110, 59, 227, 42, 139, 189, 129, 200, 48, 48, 91, 28, 233, 185, 39, 62, 60, 20, 253, 229, 16, 255, 44, 61, 167, 37, 121, 65, 246, 245, 207 } });
        }
    }
}
