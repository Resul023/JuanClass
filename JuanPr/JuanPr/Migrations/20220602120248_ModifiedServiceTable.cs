using Microsoft.EntityFrameworkCore.Migrations;

namespace JuanPr.Migrations
{
    public partial class ModifiedServiceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BkColor",
                table: "Services",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BkColor",
                table: "Services");
        }
    }
}
