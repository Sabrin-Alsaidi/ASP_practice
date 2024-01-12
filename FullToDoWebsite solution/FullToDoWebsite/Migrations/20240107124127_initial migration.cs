using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FullToDoWebsite.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "todoTask",
                columns: table => new
                {
                    Task_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Task_todo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Task_description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Task_DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Task_Status = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_todoTask", x => x.Task_id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "todoTask");
        }
    }
}
