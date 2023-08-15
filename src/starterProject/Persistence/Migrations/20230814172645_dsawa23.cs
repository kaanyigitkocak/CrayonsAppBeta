using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dsawa23 : Migration
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

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "Invoices");

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNumber",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "Invoices",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(255)",
                oldMaxLength: 255);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Files",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "InvoiceId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentFile", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentFile_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 14, 20, 26, 44, 867, DateTimeKind.Local).AddTicks(7725));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 14, 20, 26, 44, 867, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 110, 175, 66, 41, 42, 95, 153, 179, 170, 95, 100, 23, 187, 240, 223, 87, 117, 174, 97, 20, 183, 63, 240, 102, 20, 151, 194, 162, 37, 47, 72, 113, 223, 208, 70, 215, 205, 15, 232, 53, 45, 76, 250, 65, 252, 225, 216, 57, 42, 111, 181, 130, 69, 199, 199, 238, 24, 32, 87, 244, 229, 35, 224, 54 }, new byte[] { 75, 193, 161, 130, 40, 96, 24, 60, 128, 245, 25, 130, 153, 11, 38, 230, 238, 91, 174, 104, 6, 235, 208, 152, 244, 202, 222, 220, 56, 217, 110, 172, 233, 165, 72, 246, 176, 96, 100, 97, 223, 201, 11, 225, 115, 16, 158, 34, 87, 29, 11, 28, 245, 130, 74, 63, 231, 207, 119, 235, 76, 227, 255, 71, 9, 221, 199, 162, 208, 223, 116, 161, 14, 120, 23, 186, 218, 244, 66, 184, 97, 179, 238, 85, 76, 205, 249, 176, 177, 0, 6, 77, 159, 2, 24, 202, 118, 119, 44, 59, 138, 104, 168, 0, 253, 108, 31, 203, 109, 154, 152, 156, 43, 236, 221, 67, 227, 2, 113, 107, 165, 168, 145, 66, 112, 116, 93, 37 } });

            migrationBuilder.CreateIndex(
                name: "IX_Files_InvoiceId",
                table: "Files",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentFile_StudentId",
                table: "StudentFile",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Invoices_InvoiceId",
                table: "Files",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Invoices_InvoiceId",
                table: "Files");

            migrationBuilder.DropTable(
                name: "StudentFile");

            migrationBuilder.DropIndex(
                name: "IX_Files_InvoiceId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "InvoiceId",
                table: "Files");

            migrationBuilder.AddColumn<int>(
                name: "FileId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNumber",
                table: "Invoices",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Detail",
                table: "Invoices",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "FileId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 11, 12, 21, 231, DateTimeKind.Local).AddTicks(7581));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 11, 12, 21, 231, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 197, 124, 130, 30, 221, 111, 84, 82, 202, 223, 61, 134, 52, 228, 192, 78, 189, 114, 136, 61, 26, 231, 141, 100, 39, 192, 64, 140, 223, 124, 185, 67, 30, 163, 189, 84, 11, 68, 190, 41, 122, 194, 12, 220, 248, 84, 182, 32, 255, 188, 127, 28, 46, 66, 7, 113, 194, 32, 0, 167, 179, 85, 170, 235 }, new byte[] { 245, 137, 41, 95, 122, 156, 67, 147, 178, 34, 211, 189, 228, 82, 25, 183, 18, 49, 191, 44, 40, 250, 65, 142, 219, 112, 1, 10, 11, 52, 242, 231, 38, 65, 11, 31, 112, 125, 27, 52, 121, 24, 207, 162, 212, 220, 51, 14, 98, 185, 100, 155, 153, 220, 121, 229, 61, 210, 94, 22, 246, 129, 231, 48, 0, 117, 180, 233, 76, 184, 26, 241, 36, 148, 78, 56, 179, 54, 59, 234, 172, 212, 126, 212, 192, 51, 114, 21, 1, 242, 43, 49, 116, 57, 185, 153, 116, 166, 210, 115, 112, 124, 89, 252, 224, 87, 50, 65, 131, 162, 152, 50, 3, 13, 1, 60, 121, 234, 222, 71, 172, 57, 48, 191, 159, 47, 10, 10 } });

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
    }
}
