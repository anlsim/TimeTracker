using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class UpdatingVersion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14d335a8-af25-41cb-86cd-08e0241466fb", "AQAAAAEAACcQAAAAEI3b1J4CpOAx80dEEGXL9jsD62cEMOEftQLseaievK9S/t+yvbODCxtApPPNsxCufA==", "0effabbb-7989-49c1-90b2-f60bd2c22de3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fffdf8dd-000f-46e2-aec6-99fffb9429e5", "AQAAAAEAACcQAAAAEMRbkLyG3Ubk0El6yknQ6TyxAipO9prbBGVu9owpLaJxJh4zoa7cvdlLI1fkuHQ77g==", "5a6d3ea4-f007-4c92-930e-b5f446c673b2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

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
