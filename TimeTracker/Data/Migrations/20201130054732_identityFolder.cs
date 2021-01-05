using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class identityFolder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
