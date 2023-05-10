using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Infrastructure.Migrations
{
    public partial class AddSEEd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("d9c593ce-a059-4d3e-8423-e274428b7264"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("707cc303-3e29-42d2-be97-c2b85c22e4d2"), null, "avatar.jpg", "Mustafa Al-Khayat", "Microsoft test / " });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owner",
                keyColumn: "Id",
                keyValue: new Guid("707cc303-3e29-42d2-be97-c2b85c22e4d2"));

            migrationBuilder.InsertData(
                table: "Owner",
                columns: new[] { "Id", "AddressId", "Avatar", "FullName", "Profil" },
                values: new object[] { new Guid("d9c593ce-a059-4d3e-8423-e274428b7264"), null, "avatar.jpg", "Khalid ESSAADANI", "Microsoft MVP / .NET Consultant" });
        }
    }
}
