using System;
using Microsoft.EntityFrameworkCore.Migrations;
using NodaTime;

namespace SerilogPostgresNodaTime.Migrations
{
    public partial class NodaTimeAddition : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<OffsetDateTime>(
                name: "mydate",
                table: "table1",
                nullable: false,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "mydate",
                table: "table1",
                nullable: false,
                oldClrType: typeof(OffsetDateTime));
        }
    }
}
