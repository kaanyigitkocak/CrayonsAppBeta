using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class fileadeed6 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Invoices_Id",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Students_Id",
                table: "Files");

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
                value: new DateTime(2023, 8, 13, 10, 37, 16, 311, DateTimeKind.Local).AddTicks(4918));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 10, 37, 16, 311, DateTimeKind.Local).AddTicks(4930));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 194, 200, 201, 209, 193, 152, 87, 125, 211, 227, 203, 31, 35, 205, 177, 103, 122, 72, 115, 72, 60, 84, 58, 226, 192, 56, 139, 43, 180, 177, 49, 30, 223, 120, 41, 66, 51, 72, 18, 53, 230, 91, 191, 205, 76, 17, 168, 44, 236, 63, 227, 215, 109, 180, 151, 155, 118, 200, 108, 105, 49, 140, 113, 231 }, new byte[] { 150, 146, 206, 118, 57, 175, 106, 65, 152, 48, 64, 118, 102, 40, 100, 45, 202, 117, 140, 181, 133, 163, 88, 2, 55, 58, 245, 243, 56, 122, 122, 7, 254, 39, 45, 54, 52, 17, 202, 231, 178, 238, 245, 95, 162, 209, 246, 175, 76, 4, 107, 119, 134, 108, 13, 218, 154, 119, 233, 10, 189, 152, 205, 135, 104, 191, 189, 159, 160, 227, 27, 192, 53, 246, 249, 227, 64, 192, 85, 106, 190, 242, 250, 102, 30, 115, 4, 104, 79, 36, 147, 112, 1, 183, 12, 211, 128, 209, 132, 204, 40, 234, 206, 25, 239, 172, 179, 51, 194, 134, 169, 127, 73, 231, 15, 249, 231, 3, 37, 35, 96, 123, 25, 56, 2, 25, 162, 241 } });

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
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Files_FileId",
                table: "Students",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }
    }
}
