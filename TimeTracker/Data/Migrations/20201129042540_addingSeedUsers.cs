using Microsoft.EntityFrameworkCore.Migrations;

namespace LWTechTaskTimeTracker.Data.Migrations
{
    public partial class addingSeedUsers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3f9b0d15-de9b-4725-b2d2-6da825cb7abc", 0, "bf52e655-51ce-474e-87b1-1fe072f70a99", "john@lwtech.edu", true, false, null, "JOHN@LWTECH.EDU", null, "AQAAAAEAACcQAAAAEC2wSE/9C/12v6DlMqXlgBdlPlgqMW+oXS1pvGQj/AWhrkNBuhbbBZS51NdPbCETVQ==", "1231230202", false, "d7f49360-b30f-45f7-a419-48a8dfe6182c", false, "John" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc", 0, "3525cd88-1414-47fa-a5b3-46fbc5f71af7", "maria@lwtech.c=edu", true, false, null, "MARIA@LWTECH.EDU", null, "AQAAAAEAACcQAAAAEAGlbq8KDcWsHS0cJmbaRfcEpvTCbInJVh6Aay3YLIAlvqScOKxlsz7XZzSKAnpHIQ==", "2062220000", false, "13cbb146-6d10-497f-8344-7b94f1cba543", false, "Maria" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3f9b0d15-de9b-4725-b2d2-6da825cb7abc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "674ed0e-dc9e-45af-bbfa-85a9ee0e1abc");
        }
    }
}
