using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class fileadeed2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Invoices.Admin", null },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Invoices.Read", null },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Invoices.Write", null },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Invoices.Add", null },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Invoices.Update", null },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Invoices.Delete", null },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Files.Admin", null },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Files.Read", null },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Files.Write", null },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Files.Add", null },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Files.Update", null },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Files.Delete", null }
                });

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 10, 19, 48, 306, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2023, 8, 13, 10, 19, 48, 306, DateTimeKind.Local).AddTicks(531));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 238, 65, 97, 216, 22, 122, 150, 186, 62, 4, 43, 217, 110, 49, 187, 43, 146, 187, 181, 77, 23, 134, 179, 214, 21, 158, 243, 253, 240, 35, 228, 20, 68, 185, 247, 93, 160, 225, 176, 231, 172, 150, 103, 243, 33, 17, 205, 169, 46, 189, 105, 128, 137, 105, 187, 44, 112, 175, 19, 152, 251, 229, 125, 96 }, new byte[] { 207, 79, 28, 200, 242, 10, 239, 225, 224, 65, 19, 97, 94, 156, 53, 175, 3, 242, 91, 156, 192, 63, 191, 163, 134, 186, 124, 252, 117, 237, 110, 74, 168, 226, 228, 210, 79, 17, 204, 216, 167, 139, 40, 172, 162, 123, 52, 69, 188, 88, 153, 155, 186, 182, 30, 210, 26, 200, 140, 159, 97, 1, 237, 71, 216, 243, 126, 180, 113, 159, 110, 238, 26, 153, 96, 13, 131, 170, 113, 146, 32, 109, 22, 69, 123, 98, 98, 109, 116, 196, 129, 229, 17, 93, 72, 147, 36, 194, 183, 88, 107, 47, 105, 241, 135, 18, 84, 146, 68, 92, 2, 107, 88, 62, 49, 230, 5, 157, 190, 32, 78, 128, 17, 161, 36, 167, 98, 165 } });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 25);

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
        }
    }
}
