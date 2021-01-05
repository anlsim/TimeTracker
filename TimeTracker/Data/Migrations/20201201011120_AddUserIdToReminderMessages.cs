using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class AddUserIdToReminderMessages : Migration
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
                values: new object[] { "38addaab-8dd7-4ca5-b643-6942b161b7e3", "AQAAAAEAACcQAAAAEK8HTIGxKtwLrE8SNXeLzD2VoCsNqcjOuC/Cp3eyBgKDrd5FgaJUprM8M47ijTFo3g==", "7df8b738-c99a-4481-ba60-1ec04c3cb9c6" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56f428cb-d175-40b1-821c-2fb193dc173e", "AQAAAAEAACcQAAAAEMIxFZ+TnH5VeimkoyyB1Y7jrWb+Ui+IOrALMkZAFNqsGkgFChDmqJVpwO5W7Vj5jw==", "8100f582-a862-4d47-ae0b-e64c6de02abe" });

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
                values: new object[] { "53833681-418f-4c9f-9185-390bba21fcae", "AQAAAAEAACcQAAAAEObVqQ5sCjkBlmk3psYoRfOWy+eXG18dHdSmoSNeHQ0UC+t/oL12eUdQ22EdFpkyPg==", "3c8c4574-7364-43a5-a748-99be660d857b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1880cdd-86ba-4ae9-9fd1-222b4daf28ef", "AQAAAAEAACcQAAAAEAtZxycNChywGaLed31W6ZVHOv1M3W3sQXmP1Gform/7i9GGh4bQo5dmC1+DnfbXLQ==", "6f4adbe1-1564-4075-842b-c4b791fcaeeb" });
        }
    }
}
