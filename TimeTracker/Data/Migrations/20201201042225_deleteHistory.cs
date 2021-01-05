using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class deleteHistory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dab5f8e2-b00a-4850-a70f-35c5169432ad", "AQAAAAEAACcQAAAAENs87EcMQ8a54PyVYmw+VLwddK8kJG5nrTBPIZNGZBYhd637AKHvFSGZXZBuQnDmvA==", "9b0bead4-e4f1-42e2-bfea-6808df9f7843" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c7bd8cd5-9620-4597-955a-5114caf36543", "AQAAAAEAACcQAAAAEKwk4Kf+ky889dOao17c+BChLuzIl2WVXjiwxe3JZSIWAJIWsTVGnnjgwYRqmKa4dA==", "21d38a68-e31e-4510-b05f-3b7e6defe08b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a6037764-56e2-4c4c-9284-afb30adb8c67", "AQAAAAEAACcQAAAAEFKPNRoK3CAECWubhGPGUZAPT1+tLQkk0yJ1YO9yBZ8JcMT2fR+f/PtsJRXSkQ+5EQ==", "938f1e1b-98ea-45b9-beb6-871a8e61f450" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17dca59d-8b56-4096-95af-8184b5d045c2", "AQAAAAEAACcQAAAAEGzjWez8Zevq/dISRyurM9UL68BOXBJ9P3DeMp3L8yKKdoGBhwBlShYuJXlhtxo0Bw==", "c19299e4-f8b8-4cab-8814-febe00b1a636" });
        }
    }
}
