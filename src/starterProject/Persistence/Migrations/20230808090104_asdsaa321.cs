using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asdsaa321 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 12, 0, 24, 785, DateTimeKind.Local).AddTicks(1199));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 12, 0, 24, 785, DateTimeKind.Local).AddTicks(1212));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 66, 23, 67, 168, 106, 137, 123, 10, 211, 122, 183, 98, 81, 116, 224, 235, 62, 6, 190, 214, 193, 149, 179, 66, 238, 28, 61, 68, 121, 69, 54, 208, 237, 108, 138, 71, 132, 159, 195, 249, 48, 176, 150, 168, 163, 156, 236, 184, 39, 6, 131, 175, 144, 212, 113, 89, 167, 136, 15, 111, 174, 52, 39, 143 }, new byte[] { 99, 95, 24, 121, 35, 146, 183, 226, 9, 69, 101, 212, 210, 121, 23, 125, 73, 35, 72, 190, 186, 211, 186, 35, 14, 154, 180, 138, 154, 90, 120, 142, 73, 227, 68, 89, 124, 137, 222, 95, 211, 105, 91, 70, 174, 181, 77, 120, 186, 58, 87, 191, 30, 76, 200, 105, 177, 143, 201, 64, 69, 157, 246, 59, 50, 86, 87, 229, 160, 47, 64, 61, 66, 32, 9, 123, 231, 178, 125, 166, 33, 235, 70, 122, 253, 138, 130, 219, 195, 39, 74, 173, 169, 251, 141, 177, 154, 18, 7, 81, 189, 207, 21, 124, 34, 236, 111, 60, 43, 77, 84, 146, 206, 123, 3, 230, 21, 206, 95, 59, 96, 129, 247, 38, 19, 246, 250, 175 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
