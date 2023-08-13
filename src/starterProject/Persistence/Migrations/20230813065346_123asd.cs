using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class _123asd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FileId",
                table: "Students",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Files",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FullPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    MimeType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Files", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsPaid = table.Column<bool>(type: "bit", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    FileId = table.Column<int>(type: "int", nullable: false),
                    FileId1 = table.Column<int>(type: "int", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Invoices_Files_FileId",
                        column: x => x.FileId,
                        principalTable: "Files",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Invoices_Files_FileId1",
                        column: x => x.FileId1,
                        principalTable: "Files",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Invoices_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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
                table: "Students",
                keyColumn: "Id",
                keyValue: 1,
                column: "FileId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Students",
                keyColumn: "Id",
                keyValue: 2,
                column: "FileId",
                value: 0);

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

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_ParentId",
                table: "Invoices",
                column: "ParentId");

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
                name: "FK_Students_Files_FileId",
                table: "Students");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Files");

            migrationBuilder.DropIndex(
                name: "IX_Students_FileId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "FileId",
                table: "Students");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 12, 37, 5, 50, DateTimeKind.Local).AddTicks(1809));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 8, 12, 37, 5, 50, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 34, 12, 95, 101, 210, 198, 132, 24, 201, 92, 128, 123, 28, 93, 172, 218, 129, 215, 186, 237, 136, 209, 85, 169, 109, 169, 237, 65, 88, 84, 209, 161, 57, 28, 237, 154, 169, 236, 51, 73, 245, 166, 36, 130, 64, 36, 89, 81, 43, 54, 188, 118, 83, 121, 0, 212, 252, 25, 32, 241, 255, 54, 124, 48 }, new byte[] { 105, 11, 166, 212, 3, 125, 28, 137, 173, 197, 87, 254, 66, 84, 66, 109, 64, 112, 11, 44, 238, 48, 146, 242, 141, 46, 38, 223, 169, 190, 245, 250, 139, 200, 30, 56, 46, 8, 2, 153, 6, 178, 143, 174, 253, 57, 109, 126, 122, 198, 199, 21, 100, 99, 91, 209, 119, 178, 230, 170, 228, 36, 162, 47, 5, 74, 101, 18, 37, 190, 20, 154, 88, 254, 46, 201, 39, 85, 8, 164, 42, 243, 89, 252, 181, 248, 35, 144, 68, 182, 76, 175, 39, 181, 161, 53, 155, 162, 10, 99, 99, 28, 99, 139, 218, 181, 28, 58, 109, 139, 14, 173, 24, 16, 138, 206, 38, 186, 180, 121, 110, 163, 218, 170, 54, 43, 185, 248 } });
        }
    }
}
