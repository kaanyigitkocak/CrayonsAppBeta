using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asdsaa3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_TeacherId",
                table: "Students");

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
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_TeacherId",
                table: "Students",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_TeacherId",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 11, 45, 34, 150, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 11, 45, 34, 150, DateTimeKind.Local).AddTicks(8165));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 186, 77, 152, 246, 169, 73, 111, 199, 210, 248, 244, 30, 50, 10, 32, 21, 40, 181, 234, 26, 49, 106, 142, 105, 124, 28, 198, 238, 174, 237, 114, 98, 197, 232, 104, 185, 113, 36, 245, 68, 5, 3, 84, 7, 28, 23, 51, 120, 117, 140, 152, 87, 50, 143, 113, 113, 67, 38, 203, 37, 160, 141, 38, 60 }, new byte[] { 180, 69, 87, 233, 240, 107, 124, 64, 191, 31, 69, 65, 0, 220, 32, 132, 23, 31, 170, 67, 236, 249, 212, 2, 33, 15, 26, 93, 56, 135, 42, 16, 88, 36, 194, 251, 205, 231, 129, 146, 215, 179, 169, 59, 101, 232, 100, 118, 59, 33, 165, 34, 136, 227, 120, 156, 247, 16, 214, 149, 248, 94, 142, 74, 134, 74, 46, 19, 75, 255, 223, 201, 91, 69, 213, 77, 162, 152, 145, 58, 58, 207, 138, 140, 102, 166, 93, 46, 189, 176, 24, 66, 236, 201, 103, 99, 167, 159, 33, 221, 140, 78, 59, 112, 168, 243, 151, 115, 75, 201, 152, 232, 75, 68, 52, 13, 155, 6, 19, 89, 169, 155, 234, 53, 42, 57, 51, 230 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_TeacherId",
                table: "Students",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
