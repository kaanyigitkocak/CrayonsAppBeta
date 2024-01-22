using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init321 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 23, 53, 22, 159, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 23, 53, 22, 159, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 59, 112, 155, 65, 49, 77, 48, 48, 226, 46, 113, 238, 31, 24, 85, 23, 95, 109, 87, 169, 126, 230, 44, 150, 46, 48, 79, 198, 200, 68, 161, 28, 63, 160, 68, 209, 97, 214, 15, 205, 44, 69, 153, 26, 123, 1, 167, 112, 82, 180, 2, 79, 46, 213, 11, 234, 6, 58, 226, 17, 121, 122, 192, 113 }, new byte[] { 102, 86, 164, 66, 105, 181, 48, 29, 50, 72, 136, 216, 79, 170, 7, 229, 86, 67, 168, 235, 202, 19, 182, 245, 28, 94, 172, 220, 239, 158, 137, 123, 226, 182, 53, 150, 124, 102, 15, 205, 42, 99, 200, 150, 249, 98, 14, 186, 189, 30, 33, 6, 30, 241, 97, 146, 178, 134, 213, 5, 113, 209, 46, 190, 250, 182, 82, 128, 128, 38, 152, 229, 150, 178, 248, 119, 177, 28, 177, 134, 137, 125, 84, 242, 30, 29, 147, 252, 21, 16, 102, 3, 65, 252, 74, 103, 231, 231, 102, 73, 187, 164, 152, 102, 227, 185, 107, 193, 169, 157, 123, 61, 121, 139, 85, 108, 211, 200, 81, 64, 194, 114, 51, 6, 92, 221, 227, 159 } });
        }
    }
}
