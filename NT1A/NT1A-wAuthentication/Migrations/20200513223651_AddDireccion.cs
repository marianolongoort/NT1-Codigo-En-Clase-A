using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace NT1A_wAuthentication.Migrations
{
    public partial class AddDireccion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DireccionId",
                table: "Personas",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Direcciones",
                columns: table => new
                {
                    DireccionId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Calle = table.Column<string>(nullable: true),
                    Numero = table.Column<int>(nullable: false),
                    CodigoPostal = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Direcciones", x => x.DireccionId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personas_Direcciones_DireccionId",
                table: "Personas");

            migrationBuilder.DropTable(
                name: "Direcciones");

            migrationBuilder.DropIndex(
                name: "IX_Personas_DireccionId",
                table: "Personas");

            migrationBuilder.DropColumn(
                name: "DireccionId",
                table: "Personas");
        }
    }
}
