using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class parentupdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_ParentId",
                table: "Students");

            migrationBuilder.DropColumn(
                name: "StudentId",
                table: "Parents");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 169, 192, 199, 245, 109, 107, 79, 221, 184, 103, 102, 29, 27, 33, 97, 10, 91, 35, 101, 178, 200, 13, 83, 174, 52, 175, 110, 6, 226, 189, 84, 46, 239, 241, 64, 188, 104, 101, 25, 136, 72, 253, 230, 222, 35, 130, 61, 35, 60, 156, 221, 123, 139, 155, 54, 60, 84, 0, 119, 193, 252, 183, 184, 147 }, new byte[] { 249, 45, 24, 202, 233, 227, 37, 217, 142, 194, 58, 132, 205, 161, 185, 102, 47, 42, 91, 173, 233, 204, 75, 187, 50, 219, 66, 15, 50, 3, 29, 217, 10, 76, 226, 204, 102, 149, 253, 156, 203, 51, 133, 38, 231, 228, 105, 250, 9, 255, 116, 153, 241, 237, 77, 186, 116, 228, 73, 208, 223, 127, 100, 151, 93, 13, 151, 99, 49, 122, 27, 192, 145, 120, 125, 230, 84, 238, 38, 35, 148, 160, 144, 89, 151, 81, 221, 221, 250, 237, 221, 178, 33, 197, 217, 225, 224, 31, 249, 203, 123, 134, 167, 49, 44, 118, 104, 46, 68, 211, 172, 58, 47, 177, 115, 231, 212, 81, 252, 191, 74, 68, 113, 143, 215, 251, 126, 242 } });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Students_ParentId",
                table: "Students");

            migrationBuilder.AddColumn<int>(
                name: "StudentId",
                table: "Parents",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1,
                column: "StudentId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2,
                column: "StudentId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 128, 15, 118, 205, 135, 207, 214, 245, 176, 189, 243, 140, 109, 67, 160, 216, 233, 145, 2, 2, 223, 159, 14, 201, 28, 190, 173, 123, 29, 74, 69, 150, 209, 252, 154, 92, 82, 79, 25, 2, 151, 232, 84, 157, 118, 215, 237, 238, 129, 114, 189, 77, 169, 104, 237, 243, 237, 199, 236, 48, 4, 78, 38, 92 }, new byte[] { 200, 116, 42, 9, 222, 221, 12, 151, 224, 90, 51, 196, 134, 99, 46, 119, 237, 172, 71, 15, 94, 176, 250, 214, 144, 113, 121, 159, 11, 2, 146, 73, 86, 59, 132, 127, 164, 200, 128, 197, 75, 235, 81, 125, 128, 78, 54, 209, 196, 138, 72, 144, 210, 32, 236, 238, 141, 148, 72, 150, 95, 44, 249, 212, 243, 29, 226, 155, 48, 173, 138, 113, 91, 208, 138, 193, 170, 25, 205, 141, 106, 176, 125, 113, 156, 90, 243, 234, 128, 224, 115, 156, 128, 164, 1, 39, 121, 197, 32, 138, 173, 94, 243, 159, 192, 154, 77, 19, 129, 33, 168, 246, 102, 74, 120, 5, 214, 103, 140, 27, 173, 236, 104, 139, 190, 158, 90, 160 } });

            migrationBuilder.CreateIndex(
                name: "IX_Students_ParentId",
                table: "Students",
                column: "ParentId",
                unique: true);
        }
    }
}
