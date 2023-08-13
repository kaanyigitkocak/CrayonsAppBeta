using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class fileadeed4 : Migration
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
