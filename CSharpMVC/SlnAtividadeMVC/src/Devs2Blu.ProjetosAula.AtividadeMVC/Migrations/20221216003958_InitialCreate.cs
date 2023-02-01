using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Devs2Blu.ProjetosAula.AtividadeMVC.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "categorias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nome = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_categorias", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "filmes",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nota = table.Column<int>(type: "int", nullable: false),
                    CategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_filmes", x => x.id);
                    table.ForeignKey(
                        name: "FK_filmes_categorias_CategoriaId",
                        column: x => x.CategoriaId,
                        principalTable: "categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "id", "nome" },
                values: new object[] { 1, "Terror" });

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "id", "nome" },
                values: new object[] { 2, "Aventura" });

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "id", "nome" },
                values: new object[] { 3, "Ficção Científica" });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "CategoriaId", "Nome", "nota" },
                values: new object[] { 1, 1, "Rec", 9 });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "CategoriaId", "Nome", "nota" },
                values: new object[] { 2, 2, "Jumanji", 1 });

            migrationBuilder.InsertData(
                table: "filmes",
                columns: new[] { "id", "CategoriaId", "Nome", "nota" },
                values: new object[] { 3, 3, "Avatar", 7 });

            migrationBuilder.CreateIndex(
                name: "IX_filmes_CategoriaId",
                table: "filmes",
                column: "CategoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "filmes");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}
