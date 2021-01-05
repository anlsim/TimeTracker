using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class Checkbox : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "CompletedTask",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CompletedTask",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f1e03bb-2c6c-449a-94b2-659a60488424", "AQAAAAEAACcQAAAAEOBKxUm0AaWCcquv2H/drGmrMK+P8SLo5QdpY+7jmUga6vQDxzznkeRn69nCPLaajw==", "8b36c551-e177-4af8-baf3-62f6d812fc73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3888ba8a-cf55-4460-ae34-3566c6b46a12", "AQAAAAEAACcQAAAAEJ8ZyrYdKFlaBfA228KU39Sx2tfBvcnYQzRZKhkBDgJV7Z1Fr6qEIQyHp7GQ9qAZrA==", "80554aad-2b99-4fd7-9e4e-6a3dc2d91909" });

            migrationBuilder.CreateIndex(
                name: "IX_CompletedTask_UserId",
                table: "CompletedTask",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedTask_AspNetUsers_UserId",
                table: "CompletedTask",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedTask_AspNetUsers_UserId",
                table: "CompletedTask");

            migrationBuilder.DropIndex(
                name: "IX_CompletedTask_UserId",
                table: "CompletedTask");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "CompletedTask");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "CompletedTask");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1de56a0f-047b-4fa2-93b3-85399be75e1c", "AQAAAAEAACcQAAAAEAM89wfxDajEODUuXDSw9aBkBIA0bOSDK773bvcJHqb9GRbU0vJxJJITjcwpKnZN1g==", "7f41fd4c-95de-4251-a928-5e4c8d84d9e4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75b35947-e675-4cbe-849d-2e66eb3fa7be", "AQAAAAEAACcQAAAAEE30TxWKtm1OF2bxxz7WmT5CFWrWan50ZJ97tjeOuhYRIyobKcClnz5N5+SXzu+z+Q==", "7dc1ef69-34e6-47ad-8141-b53e76304a97" });
        }
    }
}
