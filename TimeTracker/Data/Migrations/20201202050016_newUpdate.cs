using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class newUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
