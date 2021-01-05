using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class azureupdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4b6a9b68-ec64-4c80-81e3-87bf419a985f", "AQAAAAEAACcQAAAAEEw9HobNRqppDOw6pMnAd2v+EC96Ix533iGWLoOkQf8j7CiYMw3hclbOJvPw5POxJQ==", "8b148866-2d62-42cc-88f5-cde6cab1fc86" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a0aece7-2ccd-44ac-94be-ddaf57b1164f", "AQAAAAEAACcQAAAAEEg1ozdwzQOp7NSRBOUqsPceit8Bxq8bKoHfvkXLEmVQLt9aEpU+OOUycwmGkrmxxw==", "82e681fa-2388-4cbb-b4c8-b4145b939eba" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HistoryId",
                table: "CompletedTask",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "History",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_History", x => x.Id);
                    table.ForeignKey(
                        name: "FK_History_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_CompletedTask_HistoryId",
                table: "CompletedTask",
                column: "HistoryId");

            migrationBuilder.CreateIndex(
                name: "IX_History_UserId",
                table: "History",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_CompletedTask_History_HistoryId",
                table: "CompletedTask",
                column: "HistoryId",
                principalTable: "History",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
