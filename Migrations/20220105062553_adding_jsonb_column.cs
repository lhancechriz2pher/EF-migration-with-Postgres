using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace document.Migrations
{
    public partial class adding_jsonb_column : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "DataJsonb",
                table: "Documents",
                type: "jsonb",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataJsonb",
                table: "Documents");
        }
    }
}
