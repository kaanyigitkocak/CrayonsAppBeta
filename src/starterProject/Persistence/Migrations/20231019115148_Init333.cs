using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class Init333 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 139, 28, 183, 40, 57, 176, 27, 215, 132, 112, 122, 172, 247, 31, 169, 74, 156, 126, 23, 154, 247, 18, 119, 157, 45, 117, 69, 118, 139, 113, 39, 233, 124, 182, 13, 46, 141, 58, 69, 56, 186, 51, 72, 252, 207, 125, 138, 142, 1, 127, 226, 125, 174, 48, 217, 255, 68, 172, 222, 88, 135, 54, 17, 108 }, new byte[] { 96, 2, 202, 220, 75, 126, 46, 91, 66, 127, 21, 230, 178, 208, 181, 103, 101, 207, 214, 70, 150, 36, 55, 173, 64, 81, 150, 194, 81, 195, 249, 193, 27, 107, 170, 145, 4, 230, 91, 101, 103, 231, 181, 229, 217, 225, 103, 54, 17, 36, 140, 92, 111, 18, 39, 172, 24, 8, 61, 78, 250, 157, 151, 159, 217, 71, 134, 226, 5, 252, 122, 106, 192, 185, 197, 164, 22, 165, 24, 13, 148, 80, 65, 111, 18, 190, 214, 239, 4, 152, 39, 168, 122, 108, 143, 88, 12, 50, 154, 230, 104, 61, 146, 62, 174, 45, 229, 165, 211, 152, 193, 13, 162, 220, 99, 118, 185, 16, 153, 53, 119, 223, 171, 20, 209, 17, 59, 240 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreatedDate", "DeletedDate", "Name", "PhoneNumber", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "123 Main St", new DateTime(2023, 10, 19, 14, 50, 10, 503, DateTimeKind.Local).AddTicks(2450), null, "Sample School 1", "555-1234", null },
                    { 2, "1234 Main St", new DateTime(2023, 10, 19, 14, 50, 10, 503, DateTimeKind.Local).AddTicks(2470), null, "Sample School 2", "555-12342", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 109, 99, 135, 255, 160, 232, 32, 86, 41, 40, 65, 85, 128, 96, 199, 67, 141, 38, 68, 0, 55, 241, 103, 101, 1, 255, 227, 159, 119, 227, 197, 131, 227, 105, 190, 80, 44, 243, 91, 183, 91, 37, 19, 197, 35, 90, 166, 227, 208, 118, 4, 167, 134, 12, 131, 26, 102, 13, 192, 129, 118, 222, 22, 163 }, new byte[] { 211, 207, 240, 197, 243, 97, 1, 82, 29, 94, 124, 209, 239, 237, 248, 12, 171, 143, 65, 180, 102, 5, 42, 151, 64, 229, 134, 31, 120, 87, 90, 190, 93, 199, 12, 243, 112, 26, 119, 69, 91, 225, 182, 3, 224, 247, 57, 109, 5, 231, 102, 37, 124, 184, 124, 40, 139, 97, 136, 14, 86, 5, 206, 188, 108, 75, 196, 161, 135, 97, 52, 38, 2, 6, 147, 6, 57, 78, 98, 222, 242, 182, 97, 78, 57, 80, 67, 124, 113, 135, 99, 206, 73, 236, 191, 16, 142, 41, 15, 39, 179, 192, 166, 29, 181, 151, 237, 79, 55, 35, 29, 53, 73, 236, 182, 242, 215, 127, 23, 13, 47, 173, 254, 15, 125, 223, 163, 251 } });
        }
    }
}
