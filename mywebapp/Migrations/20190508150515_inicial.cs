using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace mywebapp.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RegisterInfo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    TeamRoom = table.Column<string>(nullable: true),
                    Password = table.Column<string>(nullable: true),
                    ConfirmPasword = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RegisterInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TeamRooms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TeamRoomName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamRooms", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(maxLength: 20, nullable: false),
                    Birthday = table.Column<DateTime>(nullable: false),
                    Password = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RegisterInfo");

            migrationBuilder.DropTable(
                name: "TeamRooms");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
