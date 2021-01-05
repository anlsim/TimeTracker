using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class googleSignin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5befb35-e91d-4ffa-93bc-391df9315db8", "AQAAAAEAACcQAAAAEGwh6hr4yM/OdB/HU96rBhzAX1TJuz8/czn3Kd0OX6xZS/qkmviDauaexc9oSCMI4A==", "8cd7d174-209d-4486-a6c5-7ca0d515c5b8" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4e6dfa2d-86dd-4e51-9ecb-c0b6c13b29a0", "AQAAAAEAACcQAAAAEBbLUqyNwmukUDsQ3DC4eDoHzNBdj5k+DTg3w1LUcUL7G31bZjR4ON8TeLYsuvliLQ==", "2f055ef4-dd2e-42fc-b730-5be44eb3aadb" });
        }
    }
}
