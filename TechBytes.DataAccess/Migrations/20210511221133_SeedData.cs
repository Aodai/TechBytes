using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechBytes.DataAccess.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_AspNetUsers_AuthorId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1cc9ca68-70de-4465-b768-45b6b5fbdda0", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1cc9ca68-70de-4465-b768-45b6b5fbdda0", "2" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1cc9ca68-70de-4465-b768-45b6b5fbdda0");

            migrationBuilder.RenameColumn(
                name: "AuthorId",
                table: "Posts",
                newName: "AuthorID");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorID",
                table: "Posts",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "ca9a97d9-714a-4c79-8e4f-3335d28ba344");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "29670498-9e0f-4101-956a-5b763eda06c1");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "32cb8858-dfa1-40fe-b6fc-65a960e850ec", 0, "b360ccc0-ac68-404a-9ce1-01acee618a55", "aodai100@gmail.com", true, false, null, null, null, "AQAAAAEAACcQAAAAECXTeY9tKA1lcG1vX5/OaAuHvVHtFpKqP5QFQWblhlDdE7tE0A2VI/sBvMMzoftfqQ==", null, false, "8c8b131e-2944-4462-8cbe-64a6bafe923c", false, "aodai100@gmail.com" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "ID", "Url" },
                values: new object[] { new Guid("feb3c6c9-8cfc-4835-b037-2ed8be8e6eab"), "/TechBytes" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "32cb8858-dfa1-40fe-b6fc-65a960e850ec", "1" },
                    { "32cb8858-dfa1-40fe-b6fc-65a960e850ec", "2" }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "ID", "AuthorID", "BlogID", "CategoryID", "Content", "Modified", "Published", "Title" },
                values: new object[,]
                {
                    { new Guid("4e9dc784-648d-46bd-beb8-32c7f50466cd"), "32cb8858-dfa1-40fe-b6fc-65a960e850ec", new Guid("feb3c6c9-8cfc-4835-b037-2ed8be8e6eab"), null, "Bla bla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 11, 22, 11, 32, 585, DateTimeKind.Utc).AddTicks(2920), "Post1" },
                    { new Guid("9b4ed8fa-e159-40b3-936d-7c3c74168d96"), "32cb8858-dfa1-40fe-b6fc-65a960e850ec", new Guid("feb3c6c9-8cfc-4835-b037-2ed8be8e6eab"), null, "Bla bla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 11, 22, 11, 32, 585, DateTimeKind.Utc).AddTicks(3568), "Post2" },
                    { new Guid("4c8a1278-b0ca-4e10-861f-6d726ca78dcc"), "32cb8858-dfa1-40fe-b6fc-65a960e850ec", new Guid("feb3c6c9-8cfc-4835-b037-2ed8be8e6eab"), null, "Bla bla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 11, 22, 11, 32, 585, DateTimeKind.Utc).AddTicks(3598), "Post3" },
                    { new Guid("3c2752d6-188e-426b-af4b-d9af1ea74474"), "32cb8858-dfa1-40fe-b6fc-65a960e850ec", new Guid("feb3c6c9-8cfc-4835-b037-2ed8be8e6eab"), null, "Bla bla", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 11, 22, 11, 32, 585, DateTimeKind.Utc).AddTicks(3601), "Post4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "32cb8858-dfa1-40fe-b6fc-65a960e850ec", "1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "32cb8858-dfa1-40fe-b6fc-65a960e850ec", "2" });

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("3c2752d6-188e-426b-af4b-d9af1ea74474"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("4c8a1278-b0ca-4e10-861f-6d726ca78dcc"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("4e9dc784-648d-46bd-beb8-32c7f50466cd"));

            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "ID",
                keyValue: new Guid("9b4ed8fa-e159-40b3-936d-7c3c74168d96"));

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "32cb8858-dfa1-40fe-b6fc-65a960e850ec");

            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "ID",
                keyValue: new Guid("feb3c6c9-8cfc-4835-b037-2ed8be8e6eab"));

            migrationBuilder.RenameColumn(
                name: "AuthorID",
                table: "Posts",
                newName: "AuthorId");

            migrationBuilder.AlterColumn<string>(
                name: "AuthorId",
                table: "Posts",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "c8aeba67-fb12-44d9-bd64-643dd816d6c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2",
                column: "ConcurrencyStamp",
                value: "f944db4c-d0cc-4394-add7-2314ed812f41");

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

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_AspNetUsers_AuthorId",
                table: "Posts",
                column: "AuthorId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
