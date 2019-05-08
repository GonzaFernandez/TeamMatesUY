using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mywebapp.Migrations
{
    public partial class second : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterInfo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisterInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    ConfirmPasword = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    TeamRoom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterInfo", x => x.Id);
                });
        }
    }
}
