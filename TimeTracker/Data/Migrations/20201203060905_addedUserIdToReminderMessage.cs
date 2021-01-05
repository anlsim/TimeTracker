using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class addedUserIdToReminderMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "ReminderMessage",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5b0ee966-c55c-4ded-82cc-718d55cd5fe2", "AQAAAAEAACcQAAAAEO2ea66cY0CYbq+ymD3JzAA+8EmDbG/0z1se4I/FHDqpVt3HVcCB77hrfG1pkz/nLw==", "c354cda4-8e6d-4f21-86f3-8aa81f312777" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42c1cbc7-cbf2-45ea-be51-15a5bb829943", "AQAAAAEAACcQAAAAEIGxeJLIHal8XlZVA4rclarG4iX0fgdW3fv3+idWrEPdFNjgG21uMbemD9HTF30vOQ==", "b56693df-cee1-468a-b8be-085398086f31" });

            migrationBuilder.CreateIndex(
                name: "IX_ReminderMessage_UserId",
                table: "ReminderMessage",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReminderMessage_AspNetUsers_UserId",
                table: "ReminderMessage",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReminderMessage_AspNetUsers_UserId",
                table: "ReminderMessage");

            migrationBuilder.DropIndex(
                name: "IX_ReminderMessage_UserId",
                table: "ReminderMessage");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ReminderMessage");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7bea0236-6b8e-4cf4-ae76-363c49265e03", "AQAAAAEAACcQAAAAEPIDR/0npl89vv/kXx6JtFcaC6+zVnZxDFGxMK5V7KxFC6ofYIPIyWc1DDaNxAKv6Q==", "1d44b4d7-2852-4bfd-8aca-eb5b25c02ed4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "09f9a3d2-2ab7-409f-8f2c-0375c5bc95c2", "AQAAAAEAACcQAAAAED+BXyjcbQd43dCKEz64lyo6gTEoPPf+HF6ofl3QNpMiZShheX1uJAgzU+geYD1m8w==", "0246cf45-3ddd-49e3-b728-240649e19f53" });
        }
    }
}
