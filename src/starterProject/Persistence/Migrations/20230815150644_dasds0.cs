using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dasds0 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
