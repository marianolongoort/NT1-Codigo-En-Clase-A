using Microsoft.EntityFrameworkCore.Migrations;

namespace NT1A_wAuthentication.Migrations
{
    public partial class telefonos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefono_Personas_PersonaId",
                table: "Telefono");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefono",
                table: "Telefono");

            migrationBuilder.RenameTable(
                name: "Telefono",
                newName: "Telefonos");

            migrationBuilder.RenameIndex(
                name: "IX_Telefono_PersonaId",
                table: "Telefonos",
                newName: "IX_Telefonos_PersonaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefonos",
                table: "Telefonos",
                column: "TelefonoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefonos_Personas_PersonaId",
                table: "Telefonos",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telefonos_Personas_PersonaId",
                table: "Telefonos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telefonos",
                table: "Telefonos");

            migrationBuilder.RenameTable(
                name: "Telefonos",
                newName: "Telefono");

            migrationBuilder.RenameIndex(
                name: "IX_Telefonos_PersonaId",
                table: "Telefono",
                newName: "IX_Telefono_PersonaId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telefono",
                table: "Telefono",
                column: "TelefonoID");

            migrationBuilder.AddForeignKey(
                name: "FK_Telefono_Personas_PersonaId",
                table: "Telefono",
                column: "PersonaId",
                principalTable: "Personas",
                principalColumn: "PersonaId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
