using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class addingLockout : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ebb28e8-1b03-4864-a60f-9d8d708d277f", true, "AQAAAAEAACcQAAAAEK3vXVBGCOnER6t4puANfLo++0dMpYWeeIFnBdytyzWdWh+zhjYeb7yJEdb30VYJhQ==", "83ec08d8-6230-4924-8202-caa46e0eb47a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07aa8614-7914-4eaa-a9be-1db76cea8a51", true, "AQAAAAEAACcQAAAAEDIkqMUFtdsmo+ggvIOyhFc3hisy2YQv9JnYi3hQ9Nk+nlfiz5ulcZj2L3nouuvR1g==", "47b42e27-abf0-4c64-baf0-c9a83125a2e5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc",
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf52e655-51ce-474e-87b1-1fe072f70a99", false, "AQAAAAEAACcQAAAAEC2wSE/9C/12v6DlMqXlgBdlPlgqMW+oXS1pvGQj/AWhrkNBuhbbBZS51NdPbCETVQ==", "d7f49360-b30f-45f7-a419-48a8dfe6182c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc",
                columns: new[] { "ConcurrencyStamp", "LockoutEnabled", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3525cd88-1414-47fa-a5b3-46fbc5f71af7", false, "AQAAAAEAACcQAAAAEAGlbq8KDcWsHS0cJmbaRfcEpvTCbInJVh6Aay3YLIAlvqScOKxlsz7XZzSKAnpHIQ==", "13cbb146-6d10-497f-8344-7b94f1cba543" });
        }
    }
}
