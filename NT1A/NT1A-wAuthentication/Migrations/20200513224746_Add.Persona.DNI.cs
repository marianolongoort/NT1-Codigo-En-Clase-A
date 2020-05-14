using Microsoft.EntityFrameworkCore.Migrations;

namespace NT1A_wAuthentication.Migrations
{
    public partial class AddPersonaDNI : Migration
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
