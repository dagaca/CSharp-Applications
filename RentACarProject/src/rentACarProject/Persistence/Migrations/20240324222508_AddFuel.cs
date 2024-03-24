using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddFuel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("75827191-c8aa-4c0a-a889-7dfe6225f261"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e74d580-0e56-4375-8a83-bf0cbafa547f"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("094f7797-54c6-4932-984a-bf885d562ae9"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 152, 63, 156, 166, 219, 160, 67, 234, 9, 33, 13, 162, 108, 42, 111, 218, 184, 171, 222, 55, 222, 57, 62, 136, 242, 129, 178, 157, 243, 203, 48, 95, 5, 232, 205, 97, 73, 200, 204, 50, 153, 244, 22, 108, 185, 199, 223, 186, 123, 225, 114, 223, 176, 161, 175, 114, 134, 179, 158, 160, 220, 179, 73, 209 }, new byte[] { 92, 207, 175, 71, 137, 196, 232, 177, 203, 254, 172, 180, 54, 170, 103, 82, 64, 158, 11, 196, 192, 88, 205, 15, 135, 39, 137, 121, 97, 221, 180, 220, 165, 91, 21, 159, 158, 237, 120, 51, 187, 211, 204, 13, 247, 76, 136, 75, 163, 30, 220, 245, 14, 178, 148, 100, 87, 178, 225, 109, 3, 213, 126, 128, 25, 120, 174, 161, 142, 161, 184, 9, 246, 56, 109, 210, 46, 109, 97, 123, 211, 153, 166, 231, 54, 184, 78, 96, 85, 118, 83, 106, 185, 231, 133, 202, 178, 183, 184, 153, 54, 45, 122, 216, 36, 169, 225, 185, 82, 79, 170, 237, 141, 145, 21, 244, 124, 64, 165, 214, 77, 208, 222, 60, 51, 245, 203, 220 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("e6723cb1-74aa-43f3-852f-05781ddfd150"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("094f7797-54c6-4932-984a-bf885d562ae9") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("e6723cb1-74aa-43f3-852f-05781ddfd150"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("094f7797-54c6-4932-984a-bf885d562ae9"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("4e74d580-0e56-4375-8a83-bf0cbafa547f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 147, 39, 73, 172, 36, 76, 91, 51, 15, 11, 203, 237, 169, 233, 182, 72, 74, 23, 65, 211, 246, 113, 39, 81, 233, 216, 26, 29, 100, 112, 18, 116, 49, 228, 231, 141, 167, 246, 202, 71, 183, 161, 29, 14, 158, 61, 145, 177, 247, 143, 205, 237, 184, 159, 219, 186, 90, 223, 16, 231, 244, 159, 19, 34 }, new byte[] { 184, 118, 213, 18, 215, 196, 59, 124, 11, 92, 217, 124, 133, 214, 184, 199, 84, 84, 123, 38, 59, 71, 255, 184, 59, 211, 11, 126, 59, 112, 93, 18, 95, 3, 206, 120, 231, 208, 117, 220, 125, 122, 209, 180, 156, 71, 91, 125, 6, 71, 142, 17, 25, 223, 220, 163, 221, 135, 10, 228, 58, 61, 231, 137, 239, 186, 238, 130, 205, 11, 62, 22, 35, 12, 73, 100, 67, 67, 233, 231, 129, 190, 115, 16, 153, 2, 150, 80, 56, 178, 121, 220, 199, 106, 42, 152, 26, 93, 178, 11, 111, 88, 64, 27, 28, 107, 186, 193, 119, 224, 133, 179, 19, 189, 136, 11, 116, 160, 150, 105, 187, 116, 11, 99, 52, 72, 60, 9 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("75827191-c8aa-4c0a-a889-7dfe6225f261"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("4e74d580-0e56-4375-8a83-bf0cbafa547f") });
        }
    }
}
