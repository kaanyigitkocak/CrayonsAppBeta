using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asdsa : Migration
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

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers");

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Schools.Admin", null },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Schools.Read", null },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Schools.Write", null },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Schools.Add", null },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Schools.Update", null },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Schools.Delete", null }
                });

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
                name: "FK_Students_Parents_ParentId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Teachers_TeacherId",
                table: "Students");

            migrationBuilder.DropForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Address", "CreatedDate", "DeletedDate", "Name", "PhoneNumber", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "123 Main St", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Example School", "555-123-4567", null },
                    { 2, "456 Elm Ave", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Another School", "555-987-6543", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 232, 94, 180, 218, 144, 36, 35, 212, 32, 253, 153, 145, 59, 33, 9, 89, 117, 21, 181, 81, 93, 228, 11, 66, 175, 41, 25, 156, 250, 146, 30, 6, 97, 253, 31, 58, 246, 1, 234, 138, 194, 135, 226, 26, 233, 29, 148, 4, 67, 222, 163, 23, 29, 210, 152, 28, 180, 237, 253, 182, 97, 177, 6 }, new byte[] { 166, 7, 172, 148, 220, 163, 64, 234, 216, 17, 123, 66, 100, 34, 155, 61, 177, 51, 63, 238, 187, 125, 21, 200, 99, 237, 71, 203, 108, 231, 194, 29, 13, 152, 238, 208, 228, 2, 178, 249, 139, 92, 190, 199, 254, 120, 72, 22, 176, 26, 167, 234, 15, 218, 209, 207, 50, 97, 120, 39, 190, 162, 63, 9, 14, 55, 14, 184, 104, 122, 77, 79, 226, 88, 150, 249, 34, 10, 10, 38, 199, 217, 104, 246, 60, 185, 40, 12, 199, 253, 144, 155, 209, 21, 28, 191, 250, 223, 69, 4, 56, 251, 162, 21, 55, 49, 54, 99, 190, 61, 131, 193, 43, 54, 2, 122, 128, 166, 126, 174, 119, 170, 109, 110, 201, 172, 27, 75 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Parents_ParentId",
                table: "Students",
                column: "ParentId",
                principalTable: "Parents",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Schools_SchoolId",
                table: "Students",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Teachers_TeacherId",
                table: "Students",
                column: "TeacherId",
                principalTable: "Teachers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Teachers_Schools_SchoolId",
                table: "Teachers",
                column: "SchoolId",
                principalTable: "Schools",
                principalColumn: "Id");
        }
    }
}
