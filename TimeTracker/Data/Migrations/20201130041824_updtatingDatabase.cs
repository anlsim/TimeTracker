using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class updtatingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CompletedTask_AspNetUsers_UserId",
                table: "CompletedTask");

            migrationBuilder.DropIndex(
                name: "IX_CompletedTask_UserId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "CompletedTask",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdee4f70-a85f-403c-9390-99bd4c4dedc9", "AQAAAAEAACcQAAAAEGpWxjJuhiQ6z2ueRewvzR8TiRIYYAzyNFifgpxVaod6qKMrG1BED+j1ZUxoEO1C3Q==", "0e9803cd-0684-4904-9336-aebde61b325c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d3dd340-1e0f-4a2c-966f-3668fbcf5b15", "AQAAAAEAACcQAAAAEDTHoZg63bxfnrurMovRvn4DX8ojqzQhM0dwBzQWq5l7c9Vqj6+av7WymeUCvlDXuw==", "fd2c9a37-4882-4718-be1a-599c26c2255e" });

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
    }
}
