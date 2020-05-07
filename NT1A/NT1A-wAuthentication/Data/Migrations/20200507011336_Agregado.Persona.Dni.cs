using Microsoft.EntityFrameworkCore.Migrations;

namespace NT1A_wAuthentication.Data.Migrations
{
    public partial class AgregadoPersonaDni : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Dni",
                table: "Personas",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Dni",
                table: "Personas");
        }
    }
}
