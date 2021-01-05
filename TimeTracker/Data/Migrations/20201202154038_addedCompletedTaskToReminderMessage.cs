using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class addedCompletedTaskToReminderMessage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "completedTaskId",
                table: "ReminderMessage",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_ReminderMessage_completedTaskId",
                table: "ReminderMessage",
                column: "completedTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReminderMessage_CompletedTask_completedTaskId",
                table: "ReminderMessage",
                column: "completedTaskId",
                principalTable: "CompletedTask",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReminderMessage_CompletedTask_completedTaskId",
                table: "ReminderMessage");

            migrationBuilder.DropIndex(
                name: "IX_ReminderMessage_completedTaskId",
                table: "ReminderMessage");

            migrationBuilder.DropColumn(
                name: "completedTaskId",
                table: "ReminderMessage");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "144a2346-196b-4450-806e-19edd325628a", "AQAAAAEAACcQAAAAECNb2QzBqhr48u6frXY/lcSfYwTTZEUHN/xr4esVlR4vVNVzsMKbSI6aOqwVofz0/A==", "abab4de2-ff12-4a4a-9f94-b3220c51bf04" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1a91438-d9a6-40b4-b1da-44d20e285ec4", "AQAAAAEAACcQAAAAEHSwObE2iVZvHQ5cOLAKeQG/XcbBkqr9qLw03dXDMW0kLeK/b72V0mzPDDoxys894g==", "125c4639-e796-47f6-a7b9-07298dd989a4" });
        }
    }
}
