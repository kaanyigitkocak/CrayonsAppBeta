using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class dasds02 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Invoices_InvoiceId",
                table: "Files");

            migrationBuilder.DropTable(
                name: "StudentFile");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Files",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 4, 18, 931, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 18, 4, 18, 931, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 77, 242, 251, 212, 100, 129, 78, 53, 231, 43, 187, 221, 52, 198, 233, 179, 29, 95, 167, 37, 239, 57, 219, 206, 4, 92, 148, 178, 250, 172, 203, 181, 71, 199, 111, 141, 144, 230, 68, 138, 212, 38, 234, 231, 110, 176, 201, 63, 246, 155, 225, 46, 139, 136, 166, 155, 253, 196, 113, 93, 46, 90, 211, 16 }, new byte[] { 43, 226, 251, 187, 248, 160, 175, 168, 217, 134, 22, 159, 120, 161, 27, 97, 34, 99, 61, 193, 236, 98, 82, 33, 28, 246, 215, 252, 13, 255, 188, 214, 30, 176, 216, 171, 205, 43, 79, 162, 131, 230, 69, 77, 67, 91, 209, 37, 235, 45, 155, 146, 129, 134, 209, 225, 72, 33, 29, 143, 130, 6, 28, 25, 76, 46, 160, 32, 102, 91, 89, 28, 251, 78, 18, 88, 145, 245, 158, 149, 223, 86, 26, 15, 41, 176, 18, 85, 120, 231, 5, 211, 239, 25, 118, 250, 122, 110, 59, 227, 42, 139, 189, 129, 200, 48, 48, 91, 28, 233, 185, 39, 62, 60, 20, 253, 229, 16, 255, 44, 61, 167, 37, 121, 65, 246, 245, 207 } });

            migrationBuilder.CreateIndex(
                name: "IX_Files_StudentId",
                table: "Files",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Invoices_InvoiceId",
                table: "Files",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Students_StudentId",
                table: "Files",
                column: "StudentId",
                principalTable: "Students",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Invoices_InvoiceId",
                table: "Files");

            migrationBuilder.DropForeignKey(
                name: "FK_Files_Students_StudentId",
                table: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Files_StudentId",
                table: "Files");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Files");

            migrationBuilder.CreateTable(
                name: "StudentFile",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                value: new DateTime(2023, 8, 14, 20, 27, 59, 51, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 14, 20, 27, 59, 51, DateTimeKind.Local).AddTicks(1097));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 94, 248, 164, 87, 88, 204, 61, 102, 164, 40, 159, 119, 148, 7, 57, 175, 69, 205, 248, 13, 253, 223, 118, 151, 27, 153, 47, 172, 95, 35, 202, 47, 125, 158, 193, 63, 242, 179, 111, 119, 72, 2, 216, 209, 239, 244, 227, 239, 69, 162, 228, 61, 199, 18, 108, 119, 74, 21, 239, 249, 165, 16, 122, 152 }, new byte[] { 179, 13, 51, 234, 205, 43, 201, 155, 74, 147, 27, 84, 138, 5, 199, 76, 165, 154, 72, 60, 11, 211, 140, 81, 128, 245, 236, 66, 10, 63, 213, 46, 4, 96, 126, 26, 8, 199, 19, 244, 201, 200, 251, 12, 37, 109, 150, 229, 195, 225, 54, 14, 172, 148, 122, 59, 64, 41, 16, 185, 101, 249, 146, 39, 49, 162, 217, 169, 53, 3, 176, 40, 245, 179, 202, 130, 54, 116, 130, 83, 205, 112, 151, 57, 254, 185, 127, 148, 239, 7, 78, 137, 128, 234, 221, 53, 202, 51, 168, 6, 120, 133, 36, 50, 128, 113, 144, 211, 54, 144, 42, 187, 2, 78, 116, 42, 252, 142, 142, 225, 240, 49, 156, 227, 23, 116, 201, 66 } });

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
    }
}
