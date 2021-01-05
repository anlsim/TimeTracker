using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class seedingDAtaLAstAttempt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2a6eceaf-c9dd-45d9-a517-9efce3b94d2b", "JOHN@LWTECH.EDU", "AQAAAAEAACcQAAAAECtdr/X74sPejxLiatbO4HKuR4Z1EzoejbqETzkZ/GiL+dcMWoCtMwDFH/FExf0hsA==", "e0f8efb1-2d3d-447e-93fa-94739f352080", "john@lwtech.edu" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "7bb30000-c22e-4ecf-9aea-fefdfb8a3037", "maria@lwtech.edu", "MARIA@LWTECH.EDU", "AQAAAAEAACcQAAAAEFdPUbUuLKcsI9xsztXrTzAHAXmttZOj9dtnSY48JvHGZ3K4e3VWxfh8VU6+T81hpQ==", "056ccd17-5985-4718-a4d3-9f18ffccfb01", "maria@lwtech.edu" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2ebb28e8-1b03-4864-a60f-9d8d708d277f", null, "AQAAAAEAACcQAAAAEK3vXVBGCOnER6t4puANfLo++0dMpYWeeIFnBdytyzWdWh+zhjYeb7yJEdb30VYJhQ==", "83ec08d8-6230-4924-8202-caa46e0eb47a", "John" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "07aa8614-7914-4eaa-a9be-1db76cea8a51", "maria@lwtech.c=edu", null, "AQAAAAEAACcQAAAAEDIkqMUFtdsmo+ggvIOyhFc3hisy2YQv9JnYi3hQ9Nk+nlfiz5ulcZj2L3nouuvR1g==", "47b42e27-abf0-4c64-baf0-c9a83125a2e5", "Maria" });
        }
    }
}
