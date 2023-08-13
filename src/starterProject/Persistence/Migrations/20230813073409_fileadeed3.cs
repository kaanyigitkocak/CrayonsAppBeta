using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class fileadeed3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 10, 34, 9, 394, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 10, 34, 9, 394, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 209, 21, 153, 204, 82, 15, 81, 132, 124, 151, 142, 175, 125, 61, 230, 68, 57, 137, 216, 8, 181, 222, 73, 215, 160, 117, 36, 194, 65, 228, 153, 50, 210, 165, 210, 3, 11, 39, 78, 186, 214, 10, 172, 190, 48, 200, 4, 123, 17, 194, 101, 144, 156, 147, 139, 144, 74, 84, 106, 209, 114, 147, 178, 223 }, new byte[] { 160, 117, 74, 30, 173, 97, 131, 199, 193, 255, 124, 185, 49, 96, 197, 168, 46, 32, 191, 192, 152, 237, 214, 74, 69, 95, 64, 242, 201, 124, 155, 73, 214, 246, 218, 26, 52, 244, 69, 203, 83, 155, 178, 197, 27, 192, 46, 150, 134, 166, 117, 87, 209, 176, 162, 214, 35, 78, 248, 42, 34, 33, 134, 46, 38, 19, 121, 192, 97, 208, 129, 204, 244, 116, 140, 96, 27, 200, 12, 158, 133, 74, 238, 37, 144, 105, 19, 2, 27, 215, 6, 253, 181, 50, 232, 126, 24, 24, 12, 11, 48, 153, 71, 103, 170, 135, 159, 57, 114, 80, 78, 88, 216, 27, 73, 61, 204, 213, 133, 20, 118, 167, 9, 135, 31, 199, 222, 232 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 10, 19, 48, 306, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 10, 19, 48, 306, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 65, 97, 216, 22, 122, 150, 186, 62, 4, 43, 217, 110, 49, 187, 43, 146, 187, 181, 77, 23, 134, 179, 214, 21, 158, 243, 253, 240, 35, 228, 20, 68, 185, 247, 93, 160, 225, 176, 231, 172, 150, 103, 243, 33, 17, 205, 169, 46, 189, 105, 128, 137, 105, 187, 44, 112, 175, 19, 152, 251, 229, 125, 96 }, new byte[] { 207, 79, 28, 200, 242, 10, 239, 225, 224, 65, 19, 97, 94, 156, 53, 175, 3, 242, 91, 156, 192, 63, 191, 163, 134, 186, 124, 252, 117, 237, 110, 74, 168, 226, 228, 210, 79, 17, 204, 216, 167, 139, 40, 172, 162, 123, 52, 69, 188, 88, 153, 155, 186, 182, 30, 210, 26, 200, 140, 159, 97, 1, 237, 71, 216, 243, 126, 180, 113, 159, 110, 238, 26, 153, 96, 13, 131, 170, 113, 146, 32, 109, 22, 69, 123, 98, 98, 109, 116, 196, 129, 229, 17, 93, 72, 147, 36, 194, 183, 88, 107, 47, 105, 241, 135, 18, 84, 146, 68, 92, 2, 107, 88, 62, 49, 230, 5, 157, 190, 32, 78, 128, 17, 161, 36, 167, 98, 165 } });
        }
    }
}
