using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Devs2Blu.PrimeiroExercicioAPIASPNetCore.Repository.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rating = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Rating", "Title" },
                values: new object[,]
                {
                    { 1, "Filme conta sobre uma aventura das aventuras de Plim Plim", "GENERAL AUDIENCES. ALL AGES ADMITTED", "A Aventura das Aventuras" },
                    { 2, "Filme conta sobre um roubo de um banco que Plim Plim efetuou", "PARENTAL GUIDANCE SUGGESTED. SOME MATERIAL MAY NOT BE SUITABLE FOR CHILDREN", "Plim Plim e o Roubo" },
                    { 3, "Apos roubou Plim Plim tenta fugir da prisão", "NO ONE 17 AND UNDER ADMITTED", "Plim Plim e a Fuga da Prisão" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
