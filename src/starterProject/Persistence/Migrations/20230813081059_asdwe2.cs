using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asdwe2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Invoices_Id",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Students_Id",
                table: "Files");

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Files",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 11, 10, 51, 11, DateTimeKind.Local).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 11, 10, 51, 11, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 162, 243, 209, 235, 120, 116, 36, 199, 99, 214, 145, 245, 235, 77, 29, 14, 28, 42, 52, 154, 39, 33, 244, 8, 34, 116, 88, 27, 135, 141, 177, 116, 209, 199, 128, 109, 31, 177, 142, 135, 243, 53, 80, 217, 65, 79, 192, 50, 254, 54, 185, 107, 128, 155, 171, 88, 209, 75, 5, 252, 70, 228, 24, 227 }, new byte[] { 43, 251, 169, 1, 12, 42, 44, 159, 129, 192, 11, 89, 117, 157, 245, 196, 42, 42, 175, 21, 50, 205, 201, 37, 47, 227, 185, 188, 23, 37, 77, 110, 208, 7, 111, 70, 14, 153, 40, 122, 249, 168, 248, 135, 234, 211, 9, 110, 183, 242, 209, 49, 11, 189, 165, 7, 73, 236, 246, 132, 89, 35, 50, 111, 216, 112, 4, 141, 197, 58, 148, 233, 0, 236, 88, 223, 154, 148, 75, 121, 144, 239, 159, 208, 168, 71, 213, 60, 161, 248, 62, 56, 161, 27, 167, 241, 8, 43, 168, 249, 188, 136, 168, 134, 129, 230, 147, 247, 112, 190, 255, 232, 29, 151, 145, 59, 66, 104, 11, 87, 133, 29, 248, 197, 188, 129, 118, 138 } });

            migrationBuilder.CreateIndex(
                name: "IX_Students_FileId",
                table: "Students",
                column: "FileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_FileId",
                table: "Invoices",
                column: "FileId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Files_FileId",
                table: "Invoices",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Files_FileId",
                table: "Students",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Files_FileId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Students_Files_FileId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Students_FileId",
                table: "Students");

            migrationBuilder.DropIndex(
                name: "IX_Invoices_FileId",
                table: "Invoices");

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Files",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 10, 44, 0, 427, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 10, 44, 0, 427, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "Id", "Class", "CreatedDate", "DateOfBirth", "DeletedDate", "FileId", "Name", "ParentId", "SchoolId", "TeacherId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "Grade 10", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2005, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Jane Doe", 1, 1, 1, null },
                    { 2, "Grade 8", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2006, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0, "Bob Johnson", 2, 2, 2, null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 37, 94, 248, 254, 44, 56, 222, 140, 211, 109, 39, 204, 173, 5, 175, 127, 109, 71, 239, 224, 248, 109, 109, 214, 78, 7, 205, 94, 80, 173, 60, 80, 5, 147, 111, 117, 235, 99, 146, 195, 15, 171, 49, 106, 34, 91, 56, 70, 25, 31, 169, 147, 95, 81, 60, 217, 154, 35, 141, 84, 166, 69, 73, 83 }, new byte[] { 58, 177, 155, 100, 235, 101, 91, 15, 27, 126, 251, 89, 229, 22, 248, 194, 128, 64, 30, 210, 90, 0, 35, 61, 222, 6, 151, 71, 207, 186, 173, 34, 119, 61, 53, 108, 40, 119, 149, 135, 28, 157, 66, 21, 72, 16, 209, 13, 195, 24, 147, 213, 164, 210, 111, 30, 125, 107, 66, 225, 115, 21, 148, 76, 67, 166, 8, 202, 89, 145, 86, 157, 32, 0, 35, 199, 64, 184, 145, 201, 209, 156, 104, 57, 32, 128, 237, 156, 46, 89, 138, 64, 158, 159, 194, 41, 235, 230, 136, 49, 216, 157, 104, 72, 244, 124, 61, 79, 228, 131, 85, 204, 120, 86, 118, 239, 181, 115, 221, 96, 157, 253, 79, 27, 129, 9, 186, 149 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Invoices_Id",
                table: "Files",
                column: "Id",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Students_Id",
                table: "Files",
                column: "Id",
                principalTable: "Students",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
