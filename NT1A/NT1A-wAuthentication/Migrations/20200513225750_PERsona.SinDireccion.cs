using Microsoft.EntityFrameworkCore.Migrations;

namespace NT1A_wAuthentication.Migrations
{
    public partial class PERsonaSinDireccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Direcciones_DireccionId",
                table: "Personas");

            migrationBuilder.DropIndex(
                name: "IX_Personas_DireccionId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "DireccionId",
                table: "Personas");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DireccionId",
                table: "Personas",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personas_DireccionId",
                table: "Personas",
                column: "DireccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personas_Direcciones_DireccionId",
                table: "Personas",
                column: "DireccionId",
                principalTable: "Direcciones",
                principalColumn: "DireccionId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
