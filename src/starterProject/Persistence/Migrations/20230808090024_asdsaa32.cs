using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asdsaa32 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

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
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 11, 49, 36, 304, DateTimeKind.Local).AddTicks(1775));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 11, 49, 36, 304, DateTimeKind.Local).AddTicks(1787));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 232, 188, 87, 79, 90, 134, 55, 82, 131, 51, 10, 56, 151, 190, 113, 110, 163, 187, 214, 134, 252, 66, 20, 40, 51, 18, 78, 46, 99, 57, 216, 135, 175, 13, 60, 189, 78, 20, 43, 207, 2, 9, 227, 176, 175, 24, 75, 241, 146, 66, 34, 169, 103, 155, 38, 107, 26, 160, 131, 166, 163, 110, 39, 129 }, new byte[] { 201, 39, 86, 93, 227, 65, 150, 208, 91, 108, 56, 68, 165, 5, 78, 161, 194, 205, 146, 23, 194, 45, 206, 114, 143, 57, 62, 19, 96, 7, 155, 14, 57, 126, 182, 245, 58, 174, 200, 162, 115, 30, 127, 70, 94, 75, 33, 236, 115, 133, 145, 201, 128, 157, 193, 190, 134, 167, 34, 206, 57, 9, 223, 86, 61, 57, 197, 80, 89, 34, 142, 178, 136, 118, 87, 131, 91, 95, 83, 102, 51, 118, 93, 188, 31, 5, 233, 86, 133, 123, 205, 84, 194, 131, 155, 41, 34, 225, 30, 184, 168, 41, 153, 83, 99, 204, 70, 101, 31, 219, 214, 15, 141, 187, 192, 91, 227, 107, 88, 32, 104, 167, 29, 116, 41, 177, 183, 205 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
