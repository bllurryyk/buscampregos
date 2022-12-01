using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Buscampregos.Migrations
{
    /// <inheritdoc />
    public partial class CriandoTabelaVagas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Empresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Local = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TempoPostagem = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Periodo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vagas");
        }
    }
}
