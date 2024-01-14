using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BookStoreApp.API.Migrations
{
    /// <inheritdoc />
    public partial class SeededDefaultUsersAndRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8c729c50-65c0-4de1-b7ac-8df61f66940a", null, "User", "USER" },
                    { "d9248f74-18d9-41b5-a9de-8fc231b36230", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "3ac5e110-178b-416b-ac83-c20f24d60072", 0, "7f913bf6-8cfd-4d2c-9d36-2c7640e6dc3c", "admin@bookstore.com", false, "System", "Admin", false, null, "ADMIN@BOOKSTORE.COM", "ADMIN@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEPuKf4tz0jRIaooATXAI7Dg/FyJToTXRPf0Ka7N6Ol4lEzHm4nnTNUub6ryH+PBKcQ==", null, false, "679c9059-f962-4fb6-9adb-eb615df22092", false, "admin@bookstore.com" },
                    { "589e1b6b-2b6e-4ae0-b420-acf43a5a753e", 0, "87f20694-c3c1-40cd-95af-4352e3e587c4", "user@bookstore.com", false, "System", "User", false, null, "USER@BOOKSTORE.COM", "USER@BOOKSTORE.COM", "AQAAAAIAAYagAAAAEDGFIbGCQDb3Hblc+tQgBJgy3bO76/EX0fCCoub/35WkA5z15IWfcY/PoxfAmtsn6Q==", null, false, "cd8261c4-747f-4d06-bf44-16419e232da9", false, "user@bookstore.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d9248f74-18d9-41b5-a9de-8fc231b36230", "3ac5e110-178b-416b-ac83-c20f24d60072" },
                    { "8c729c50-65c0-4de1-b7ac-8df61f66940a", "589e1b6b-2b6e-4ae0-b420-acf43a5a753e" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d9248f74-18d9-41b5-a9de-8fc231b36230", "3ac5e110-178b-416b-ac83-c20f24d60072" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8c729c50-65c0-4de1-b7ac-8df61f66940a", "589e1b6b-2b6e-4ae0-b420-acf43a5a753e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c729c50-65c0-4de1-b7ac-8df61f66940a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9248f74-18d9-41b5-a9de-8fc231b36230");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3ac5e110-178b-416b-ac83-c20f24d60072");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "589e1b6b-2b6e-4ae0-b420-acf43a5a753e");
        }
    }
}
