using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Persistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("314ab85d-e1c8-4e8c-8acf-9ea1f30b8788"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("0c349586-7c7e-4c8f-ba79-98b2a496f05c"));

            migrationBuilder.AddColumn<Guid>(
                name: "FuelId",
                table: "Models",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "OperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Admin", null },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Read", null },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Write", null },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Create", null },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Update", null },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Fuels.Delete", null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("4e74d580-0e56-4375-8a83-bf0cbafa547f"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 147, 39, 73, 172, 36, 76, 91, 51, 15, 11, 203, 237, 169, 233, 182, 72, 74, 23, 65, 211, 246, 113, 39, 81, 233, 216, 26, 29, 100, 112, 18, 116, 49, 228, 231, 141, 167, 246, 202, 71, 183, 161, 29, 14, 158, 61, 145, 177, 247, 143, 205, 237, 184, 159, 219, 186, 90, 223, 16, 231, 244, 159, 19, 34 }, new byte[] { 184, 118, 213, 18, 215, 196, 59, 124, 11, 92, 217, 124, 133, 214, 184, 199, 84, 84, 123, 38, 59, 71, 255, 184, 59, 211, 11, 126, 59, 112, 93, 18, 95, 3, 206, 120, 231, 208, 117, 220, 125, 122, 209, 180, 156, 71, 91, 125, 6, 71, 142, 17, 25, 223, 220, 163, 221, 135, 10, 228, 58, 61, 231, 137, 239, 186, 238, 130, 205, 11, 62, 22, 35, 12, 73, 100, 67, 67, 233, 231, 129, 190, 115, 16, 153, 2, 150, 80, 56, 178, 121, 220, 199, 106, 42, 152, 26, 93, 178, 11, 111, 88, 64, 27, 28, 107, 186, 193, 119, 224, 133, 179, 19, 189, 136, 11, 116, 160, 150, 105, 187, 116, 11, 99, 52, 72, 60, 9 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("75827191-c8aa-4c0a-a889-7dfe6225f261"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("4e74d580-0e56-4375-8a83-bf0cbafa547f") });

            migrationBuilder.CreateIndex(
                name: "IX_Models_FuelId",
                table: "Models",
                column: "FuelId");

            migrationBuilder.AddForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models",
                column: "FuelId",
                principalTable: "Fuels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Models_Fuels_FuelId",
                table: "Models");

            migrationBuilder.DropTable(
                name: "Fuels");

            migrationBuilder.DropIndex(
                name: "IX_Models_FuelId",
                table: "Models");

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "OperationClaims",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "UserOperationClaims",
                keyColumn: "Id",
                keyValue: new Guid("75827191-c8aa-4c0a-a889-7dfe6225f261"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("4e74d580-0e56-4375-8a83-bf0cbafa547f"));

            migrationBuilder.DropColumn(
                name: "FuelId",
                table: "Models");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AuthenticatorType", "CreatedDate", "DeletedDate", "Email", "PasswordHash", "PasswordSalt", "UpdatedDate" },
                values: new object[] { new Guid("0c349586-7c7e-4c8f-ba79-98b2a496f05c"), 0, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "narch@kodlama.io", new byte[] { 211, 51, 199, 242, 233, 236, 85, 24, 52, 172, 9, 73, 55, 249, 197, 37, 41, 247, 35, 216, 114, 173, 21, 12, 216, 227, 248, 108, 243, 249, 149, 27, 194, 136, 6, 119, 199, 66, 159, 86, 96, 157, 87, 69, 146, 96, 73, 116, 22, 68, 184, 174, 172, 142, 154, 221, 97, 67, 17, 116, 0, 37, 75, 200 }, new byte[] { 26, 221, 64, 216, 40, 90, 137, 209, 57, 40, 126, 78, 110, 95, 24, 140, 149, 220, 216, 73, 186, 97, 51, 52, 64, 223, 238, 156, 75, 191, 135, 115, 37, 153, 116, 154, 188, 50, 156, 37, 252, 20, 177, 14, 239, 244, 37, 177, 254, 42, 165, 3, 115, 153, 219, 130, 186, 89, 88, 94, 94, 229, 127, 241, 135, 90, 111, 34, 163, 18, 190, 225, 14, 45, 111, 46, 17, 135, 109, 19, 193, 82, 125, 240, 234, 40, 30, 85, 23, 239, 153, 0, 168, 36, 202, 180, 29, 156, 204, 8, 29, 87, 118, 229, 68, 131, 31, 208, 132, 43, 242, 231, 74, 142, 23, 63, 120, 226, 248, 162, 163, 221, 45, 32, 88, 216, 163, 70 }, null });

            migrationBuilder.InsertData(
                table: "UserOperationClaims",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "OperationClaimId", "UpdatedDate", "UserId" },
                values: new object[] { new Guid("314ab85d-e1c8-4e8c-8acf-9ea1f30b8788"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, null, new Guid("0c349586-7c7e-4c8f-ba79-98b2a496f05c") });
        }
    }
}
