using Microsoft.EntityFrameworkCore.Migrations;

namespace NT1A_wAuthentication.Migrations
{
    public partial class AddDireccionPersona : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonaId",
                table: "Direcciones",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_PersonaId",
                table: "Direcciones",
                column: "PersonaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Direcciones_Personas_PersonaId",
                table: "Direcciones",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Direcciones_Personas_PersonaId",
                table: "Direcciones");

            migrationBuilder.DropIndex(
                name: "IX_Direcciones_PersonaId",
                table: "Direcciones");

            migrationBuilder.DropColumn(
                name: "PersonaId",
                table: "Direcciones");
        }
    }
}
