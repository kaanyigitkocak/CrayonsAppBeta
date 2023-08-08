using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class asddasds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParentFeatures",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FeatureName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentFeatures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ParentFeatures_Parents_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ParentFeatures.Admin", null },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ParentFeatures.Read", null },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ParentFeatures.Write", null },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ParentFeatures.Add", null },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ParentFeatures.Update", null },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "ParentFeatures.Delete", null }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 193, 232, 94, 180, 218, 144, 36, 35, 212, 32, 253, 153, 145, 59, 33, 9, 89, 117, 21, 181, 81, 93, 228, 11, 66, 175, 41, 25, 156, 250, 146, 30, 6, 97, 253, 31, 58, 246, 1, 234, 138, 194, 135, 226, 26, 233, 29, 148, 4, 67, 222, 163, 23, 29, 210, 152, 28, 180, 237, 253, 182, 97, 177, 6 }, new byte[] { 166, 7, 172, 148, 220, 163, 64, 234, 216, 17, 123, 66, 100, 34, 155, 61, 177, 51, 63, 238, 187, 125, 21, 200, 99, 237, 71, 203, 108, 231, 194, 29, 13, 152, 238, 208, 228, 2, 178, 249, 139, 92, 190, 199, 254, 120, 72, 22, 176, 26, 167, 234, 15, 218, 209, 207, 50, 97, 120, 39, 190, 162, 63, 9, 14, 55, 14, 184, 104, 122, 77, 79, 226, 88, 150, 249, 34, 10, 10, 38, 199, 217, 104, 246, 60, 185, 40, 12, 199, 253, 144, 155, 209, 21, 28, 191, 250, 223, 69, 4, 56, 251, 162, 21, 55, 49, 54, 99, 190, 61, 131, 193, 43, 54, 2, 122, 128, 166, 126, 174, 119, 170, 109, 110, 201, 172, 27, 75 } });

            migrationBuilder.CreateIndex(
                name: "IX_ParentFeatures_ParentId",
                table: "ParentFeatures",
                column: "ParentId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParentFeatures");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 235, 78, 24, 90, 61, 26, 150, 0, 187, 51, 62, 221, 129, 96, 23, 5, 226, 147, 197, 106, 212, 37, 62, 112, 243, 79, 3, 213, 23, 124, 31, 52, 65, 42, 44, 50, 226, 5, 93, 163, 68, 104, 72, 130, 173, 160, 224, 213, 149, 161, 129, 139, 78, 106, 4, 180, 249, 251, 154, 10, 217, 0, 61, 41 }, new byte[] { 172, 61, 102, 162, 15, 80, 71, 239, 235, 80, 74, 250, 83, 235, 112, 136, 179, 180, 233, 177, 118, 226, 72, 150, 85, 198, 105, 129, 122, 180, 212, 27, 45, 92, 160, 242, 243, 82, 102, 86, 100, 204, 82, 248, 198, 255, 125, 158, 239, 246, 31, 13, 35, 98, 26, 111, 136, 245, 184, 242, 61, 15, 237, 207, 76, 102, 231, 229, 65, 101, 84, 143, 185, 57, 112, 113, 156, 77, 65, 7, 206, 159, 225, 79, 87, 88, 153, 227, 115, 107, 52, 236, 214, 67, 2, 143, 159, 175, 31, 193, 218, 83, 246, 3, 219, 255, 173, 117, 204, 187, 16, 227, 113, 155, 113, 64, 205, 167, 103, 215, 174, 232, 163, 194, 197, 157, 243, 59 } });
        }
    }
}
