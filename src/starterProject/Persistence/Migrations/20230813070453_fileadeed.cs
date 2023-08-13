using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class fileadeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Files_FileId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Files_FileId1",
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

            migrationBuilder.DropIndex(
                name: "IX_Invoices_FileId1",
                table: "Invoices");

            migrationBuilder.DropColumn(
                name: "FileId1",
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
                value: new DateTime(2023, 8, 13, 10, 4, 53, 690, DateTimeKind.Local).AddTicks(819));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 10, 4, 53, 690, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 188, 106, 67, 60, 153, 2, 118, 206, 188, 195, 22, 160, 7, 221, 187, 17, 193, 106, 45, 240, 209, 217, 16, 80, 197, 118, 118, 112, 71, 73, 51, 187, 61, 195, 25, 204, 162, 151, 79, 29, 165, 105, 160, 75, 242, 158, 195, 74, 200, 202, 102, 156, 3, 74, 139, 125, 80, 88, 51, 165, 254, 0, 153, 173 }, new byte[] { 129, 59, 189, 99, 111, 69, 150, 187, 91, 38, 133, 53, 192, 70, 118, 248, 96, 119, 38, 205, 12, 172, 157, 31, 169, 179, 9, 200, 64, 6, 207, 228, 71, 125, 22, 86, 54, 144, 39, 17, 35, 195, 99, 238, 152, 34, 79, 92, 10, 179, 107, 69, 195, 120, 236, 180, 231, 43, 199, 221, 173, 96, 20, 141, 199, 33, 145, 212, 21, 58, 65, 101, 35, 161, 134, 171, 163, 185, 39, 50, 12, 93, 148, 102, 231, 32, 221, 178, 42, 34, 76, 110, 248, 184, 233, 207, 164, 103, 29, 219, 142, 130, 224, 178, 198, 14, 206, 236, 112, 65, 1, 198, 57, 170, 140, 170, 142, 56, 129, 179, 39, 144, 250, 18, 26, 203, 248, 190 } });

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

            migrationBuilder.AddColumn<int>(
                name: "FileId1",
                table: "Invoices",
                type: "int",
                nullable: true);

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
                value: new DateTime(2023, 8, 13, 9, 53, 46, 233, DateTimeKind.Local).AddTicks(716));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 9, 53, 46, 233, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 251, 60, 147, 128, 246, 200, 153, 204, 180, 222, 64, 120, 119, 230, 197, 118, 88, 198, 67, 245, 179, 2, 245, 144, 112, 97, 69, 240, 18, 194, 85, 96, 106, 206, 108, 68, 118, 177, 112, 2, 163, 167, 139, 117, 125, 244, 230, 63, 61, 177, 104, 84, 163, 76, 197, 228, 165, 184, 64, 238, 69, 170, 141, 90 }, new byte[] { 205, 156, 205, 135, 152, 179, 112, 207, 20, 118, 23, 137, 122, 140, 161, 243, 67, 171, 58, 36, 200, 102, 3, 23, 30, 5, 215, 190, 23, 20, 47, 153, 248, 113, 90, 191, 25, 129, 102, 210, 141, 19, 61, 229, 116, 76, 157, 215, 129, 7, 222, 203, 81, 75, 150, 214, 54, 213, 247, 82, 130, 23, 10, 74, 121, 22, 136, 24, 252, 166, 90, 223, 156, 113, 149, 69, 75, 244, 186, 82, 12, 199, 29, 14, 21, 9, 157, 160, 193, 52, 234, 205, 44, 35, 253, 134, 117, 16, 241, 214, 79, 20, 99, 26, 106, 108, 82, 196, 102, 72, 119, 186, 228, 174, 172, 137, 16, 73, 139, 96, 175, 63, 94, 234, 207, 4, 96, 229 } });

            migrationBuilder.CreateIndex(
                name: "IX_Students_FileId",
                table: "Students",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_FileId",
                table: "Invoices",
                column: "FileId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_FileId1",
                table: "Invoices",
                column: "FileId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Files_FileId",
                table: "Invoices",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Files_FileId1",
                table: "Invoices",
                column: "FileId1",
                principalTable: "Files",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_Files_FileId",
                table: "Students",
                column: "FileId",
                principalTable: "Files",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
