using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBytes.DataAccess.Migrations
{
    public partial class SeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1", "c8aeba67-fb12-44d9-bd64-643dd816d6c3", "User", "User" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "2", "f944db4c-d0cc-4394-add7-2314ed812f41", "Administrator", "Admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1cc9ca68-70de-4465-b768-45b6b5fbdda0", 0, "aa758dc5-b1b3-4446-b440-65d05596eb06", "aodai100@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAECXTeY9tKA1lcG1vX5/OaAuHvVHtFpKqP5QFQWblhlDdE7tE0A2VI/sBvMMzoftfqQ==", null, false, "15e33d84-0670-430d-bb1b-f1e4bcbcbaaa", false, "aodai100@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "1cc9ca68-70de-4465-b768-45b6b5fbdda0", "1" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "1cc9ca68-70de-4465-b768-45b6b5fbdda0", "2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1cc9ca68-70de-4465-b768-45b6b5fbdda0", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1cc9ca68-70de-4465-b768-45b6b5fbdda0", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cc9ca68-70de-4465-b768-45b6b5fbdda0");
        }
    }
}
