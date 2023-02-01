using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Devs2Blu.ProjetosAula.ExercicioFerias.Migrations
{
    public partial class Inicialcriacao : Migration
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
                name: "noticias",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    categoriaId = table.Column<int>(type: "int", nullable: false),
                    titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    descricao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_noticias", x => x.id);
                    table.ForeignKey(
                        name: "FK_noticias_categorias_categoriaId",
                        column: x => x.categoriaId,
                        principalTable: "categorias",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1, "Crime" },
                    { 2, "Política" },
                    { 3, "Assédio" },
                    { 4, "Tecnologia" }
                });

            migrationBuilder.InsertData(
                table: "noticias",
                columns: new[] { "id", "categoriaId", "descricao", "titulo" },
                values: new object[,]
                {
                    { 1, 1, "Mulher se assustou.", "Assalto a mão armada em SP infarta mulher." },
                    { 2, 2, "Combate ao terrorismo cresce no Brasil.", "Bolsonazistas estão malucos." },
                    { 3, 3, "Infelizmente Hearthstone vai de vala.", "Blizzard novamente é processada por assédio." },
                    { 4, 4, "True, não tem jeito.", "Elon Musk não 'faz' ele apenas têm dinheiro." }
                });

            migrationBuilder.CreateIndex(
                name: "IX_noticias_categoriaId",
                table: "noticias",
                column: "categoriaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "noticias");

            migrationBuilder.DropTable(
                name: "categorias");
        }
    }
}
