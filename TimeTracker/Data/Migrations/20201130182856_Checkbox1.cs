using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class Checkbox1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "53833681-418f-4c9f-9185-390bba21fcae", "AQAAAAEAACcQAAAAEObVqQ5sCjkBlmk3psYoRfOWy+eXG18dHdSmoSNeHQ0UC+t/oL12eUdQ22EdFpkyPg==", "3c8c4574-7364-43a5-a748-99be660d857b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1880cdd-86ba-4ae9-9fd1-222b4daf28ef", "AQAAAAEAACcQAAAAEAtZxycNChywGaLed31W6ZVHOv1M3W3sQXmP1Gform/7i9GGh4bQo5dmC1+DnfbXLQ==", "6f4adbe1-1564-4075-842b-c4b791fcaeeb" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
