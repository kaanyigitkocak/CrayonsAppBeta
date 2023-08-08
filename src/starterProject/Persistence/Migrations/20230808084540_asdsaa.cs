using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asdsaa : Migration
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

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreatedDate", "DeletedDate", "Name", "PhoneNumber", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "123 Main St", new DateTime(2023, 8, 8, 11, 45, 34, 150, DateTimeKind.Local).AddTicks(8147), null, "Sample School 1", "555-1234", null },
                    { 2, "1234 Main St", new DateTime(2023, 8, 8, 11, 45, 34, 150, DateTimeKind.Local).AddTicks(8165), null, "Sample School 2", "555-12342", null }
                });

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
                values: new object[] { new byte[] { 107, 49, 243, 122, 200, 147, 110, 122, 115, 60, 157, 7, 187, 64, 59, 26, 192, 171, 121, 219, 14, 233, 231, 75, 204, 145, 74, 72, 155, 42, 248, 164, 72, 81, 242, 5, 118, 87, 71, 66, 162, 202, 47, 88, 130, 163, 141, 37, 245, 161, 103, 249, 118, 223, 151, 169, 42, 173, 84, 217, 82, 190, 57, 97 }, new byte[] { 243, 76, 163, 244, 53, 211, 188, 184, 25, 55, 64, 69, 119, 97, 82, 147, 117, 30, 57, 129, 69, 12, 116, 7, 244, 34, 2, 254, 247, 109, 206, 26, 125, 136, 117, 232, 83, 44, 185, 166, 68, 89, 1, 37, 241, 248, 106, 94, 182, 39, 224, 24, 99, 89, 195, 135, 111, 5, 184, 5, 228, 13, 184, 71, 237, 220, 42, 228, 45, 157, 130, 12, 152, 115, 223, 118, 21, 220, 100, 99, 130, 110, 11, 221, 137, 226, 198, 255, 82, 37, 44, 236, 56, 141, 197, 211, 237, 111, 120, 164, 215, 187, 162, 191, 244, 175, 233, 241, 123, 88, 26, 148, 178, 206, 219, 226, 89, 43, 54, 243, 145, 41, 173, 204, 64, 234, 95, 213 } });

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
    }
}
