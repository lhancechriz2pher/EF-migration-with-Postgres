using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace document.Migrations
{
    public partial class AddingPathColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Path",
                table: "Documents",
                type: "text",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Path",
                table: "Documents");
        }
    }
}
