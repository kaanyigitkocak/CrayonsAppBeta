using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class ad2qed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Files_Invoices_InvoiceId",
                table: "Files");

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 23, 53, 22, 159, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 23, 53, 22, 159, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 59, 112, 155, 65, 49, 77, 48, 48, 226, 46, 113, 238, 31, 24, 85, 23, 95, 109, 87, 169, 126, 230, 44, 150, 46, 48, 79, 198, 200, 68, 161, 28, 63, 160, 68, 209, 97, 214, 15, 205, 44, 69, 153, 26, 123, 1, 167, 112, 82, 180, 2, 79, 46, 213, 11, 234, 6, 58, 226, 17, 121, 122, 192, 113 }, new byte[] { 102, 86, 164, 66, 105, 181, 48, 29, 50, 72, 136, 216, 79, 170, 7, 229, 86, 67, 168, 235, 202, 19, 182, 245, 28, 94, 172, 220, 239, 158, 137, 123, 226, 182, 53, 150, 124, 102, 15, 205, 42, 99, 200, 150, 249, 98, 14, 186, 189, 30, 33, 6, 30, 241, 97, 146, 178, 134, 213, 5, 113, 209, 46, 190, 250, 182, 82, 128, 128, 38, 152, 229, 150, 178, 248, 119, 177, 28, 177, 134, 137, 125, 84, 242, 30, 29, 147, 252, 21, 16, 102, 3, 65, 252, 74, 103, 231, 231, 102, 73, 187, 164, 152, 102, 227, 185, 107, 193, 169, 157, 123, 61, 121, 139, 85, 108, 211, 200, 81, 64, 194, 114, 51, 6, 92, 221, 227, 159 } });

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

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 20, 40, 40, 281, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 15, 20, 40, 40, 281, DateTimeKind.Local).AddTicks(6753));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 96, 223, 166, 194, 8, 17, 202, 239, 36, 129, 229, 217, 231, 188, 219, 114, 209, 86, 241, 212, 13, 94, 20, 15, 62, 53, 92, 236, 136, 196, 14, 134, 141, 189, 69, 126, 78, 140, 84, 133, 168, 76, 61, 248, 94, 142, 27, 206, 203, 215, 246, 243, 180, 199, 249, 100, 1, 55, 35, 215, 37, 20, 178, 149 }, new byte[] { 244, 143, 46, 113, 237, 186, 41, 222, 30, 115, 64, 229, 68, 103, 25, 181, 102, 127, 117, 23, 4, 180, 153, 136, 62, 137, 98, 226, 251, 132, 104, 58, 231, 167, 60, 204, 213, 108, 185, 29, 172, 8, 46, 54, 217, 130, 53, 33, 185, 20, 165, 18, 143, 69, 253, 100, 122, 61, 90, 232, 153, 233, 91, 232, 103, 162, 125, 252, 71, 166, 119, 221, 235, 234, 241, 166, 103, 239, 174, 116, 214, 193, 184, 64, 207, 175, 54, 129, 83, 195, 133, 51, 3, 187, 126, 46, 83, 13, 192, 107, 6, 188, 212, 153, 194, 12, 21, 88, 121, 208, 30, 215, 180, 30, 138, 14, 234, 210, 24, 105, 239, 3, 187, 199, 254, 124, 143, 224 } });

            migrationBuilder.AddForeignKey(
                name: "FK_Files_Invoices_InvoiceId",
                table: "Files",
                column: "InvoiceId",
                principalTable: "Invoices",
                principalColumn: "Id");
        }
    }
}
