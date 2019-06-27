using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SerilogPostgresNodaTime.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "table1",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    mydate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_table1", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "table1");
        }
    }
}
