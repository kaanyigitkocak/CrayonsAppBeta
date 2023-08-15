using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dasds0222 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 6, 20, 135, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 6, 20, 135, DateTimeKind.Local).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 223, 39, 203, 136, 62, 198, 33, 167, 115, 10, 108, 46, 76, 63, 115, 212, 250, 43, 107, 230, 46, 2, 190, 52, 239, 64, 15, 171, 221, 6, 150, 70, 133, 9, 88, 20, 195, 221, 63, 71, 78, 220, 64, 5, 101, 237, 30, 134, 84, 84, 113, 37, 189, 220, 82, 248, 102, 225, 219, 196, 48, 49, 112, 179 }, new byte[] { 69, 174, 189, 48, 169, 66, 25, 44, 106, 240, 92, 227, 51, 245, 77, 188, 198, 248, 228, 71, 58, 252, 18, 121, 79, 246, 41, 252, 174, 53, 121, 63, 213, 200, 45, 16, 38, 52, 188, 241, 238, 11, 38, 25, 159, 156, 195, 211, 112, 18, 122, 148, 215, 228, 101, 70, 15, 214, 161, 148, 118, 96, 109, 78, 245, 156, 163, 28, 155, 224, 239, 190, 127, 232, 42, 220, 98, 199, 101, 211, 180, 117, 179, 77, 14, 32, 201, 11, 225, 114, 37, 13, 67, 3, 123, 255, 106, 187, 147, 88, 107, 211, 196, 71, 131, 5, 95, 216, 75, 59, 170, 200, 166, 144, 157, 199, 108, 108, 7, 50, 222, 17, 29, 243, 29, 102, 4, 101 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
