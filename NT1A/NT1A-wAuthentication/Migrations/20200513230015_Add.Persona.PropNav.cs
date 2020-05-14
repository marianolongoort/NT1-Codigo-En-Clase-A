using Microsoft.EntityFrameworkCore.Migrations;

namespace NT1A_wAuthentication.Migrations
{
    public partial class AddPersonaPropNav : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Direcciones_PersonaId",
                table: "Direcciones");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_PersonaId",
                table: "Direcciones",
                column: "PersonaId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Direcciones_PersonaId",
                table: "Direcciones");

            migrationBuilder.CreateIndex(
                name: "IX_Direcciones_PersonaId",
                table: "Direcciones",
                column: "PersonaId");
        }
    }
}
