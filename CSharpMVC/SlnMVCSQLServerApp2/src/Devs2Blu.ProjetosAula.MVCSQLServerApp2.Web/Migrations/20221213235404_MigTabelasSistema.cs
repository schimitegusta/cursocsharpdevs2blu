using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Migrations
{
    public partial class MigTabelasSistema : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtos_categorias_id_categoria",
                table: "produtos");

            migrationBuilder.RenameColumn(
                name: "id_categoria",
                table: "produtos",
                newName: "CategoriaId");

            migrationBuilder.RenameIndex(
                name: "IX_produtos_id_categoria",
                table: "produtos",
                newName: "IX_produtos_CategoriaId");

            migrationBuilder.AlterColumn<double>(
                name: "preco",
                table: "produtos",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.InsertData(
                table: "categorias",
                columns: new[] { "id", "nome" },
                values: new object[,]
                {
                    { 1, "Alimentos Não Perecíveis" },
                    { 2, "Laticínios" },
                    { 3, "Limpeza" },
                    { 4, "Bebidas Não Alcoólicas" }
                });

            migrationBuilder.InsertData(
                table: "produtos",
                columns: new[] { "id", "CategoriaId", "nome", "preco", "quantidade" },
                values: new object[,]
                {
                    { 1, 1, "Arroz", 10.0, 5 },
                    { 2, 1, "Feijao", 10.0, 2 },
                    { 3, 2, "Queijo", 10.0, 6 },
                    { 4, 2, "Iorgute", 10.0, 3 },
                    { 5, 3, "Sabao Liquido", 10.0, 5 },
                    { 6, 3, "Multiuso", 10.0, 5 },
                    { 7, 4, "Suco de Limao", 10.0, 2 },
                    { 8, 4, "Coca-cola Zero 2L", 10.0, 1 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_categorias_CategoriaId",
                table: "produtos",
                column: "CategoriaId",
                principalTable: "categorias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_produtos_categorias_CategoriaId",
                table: "produtos");

            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "produtos",
                keyColumn: "id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "categorias",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "categorias",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "categorias",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "categorias",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.RenameColumn(
                name: "CategoriaId",
                table: "produtos",
                newName: "id_categoria");

            migrationBuilder.RenameIndex(
                name: "IX_produtos_CategoriaId",
                table: "produtos",
                newName: "IX_produtos_id_categoria");

            migrationBuilder.AlterColumn<decimal>(
                name: "preco",
                table: "produtos",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.AddForeignKey(
                name: "FK_produtos_categorias_id_categoria",
                table: "produtos",
                column: "id_categoria",
                principalTable: "categorias",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
