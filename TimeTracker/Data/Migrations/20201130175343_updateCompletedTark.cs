using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class updateCompletedTark : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CompletedTask",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40d404d0-f4eb-4818-a00e-c32afe2480e6", "AQAAAAEAACcQAAAAEFah8E+GxqqPz/bsoXz4vu+xEmDLwq+IXJHOSfM8nBQQ4F0bq79Q6U9mht+Eu1qZzQ==", "8517af44-b756-49c0-82f4-a4493f477c0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b10bd942-0509-4b9c-a634-c03d6b97da37", "AQAAAAEAACcQAAAAEO5yzY5oo9C9+lB0MTsewe+khr8jSBnZ30gixsOoJnZteEOo+IutRvcd1onPGZpNxw==", "f25648b6-2d1d-4a39-8ae1-7163db629f70" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "CompletedTask",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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
        }
    }
}
