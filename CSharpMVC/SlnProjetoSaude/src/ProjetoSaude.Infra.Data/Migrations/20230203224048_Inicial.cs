using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjetoSaude.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class Inicial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Endereco",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rua = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Numero = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CEP = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Regiao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Endereco", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Pessoa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnderecoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoa", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pessoa_Endereco_EnderecoId",
                        column: x => x.EnderecoId,
                        principalTable: "Endereco",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipoSanquineo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Limitacao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Alergia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paciente_Pessoa_PessoaId",
                        column: x => x.PessoaId,
                        principalTable: "Pessoa",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Agenda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titulo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataConsulta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agenda", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Agenda_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Prontuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DataAbertura = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PacienteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Prontuario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Prontuario_Paciente_PacienteId",
                        column: x => x.PacienteId,
                        principalTable: "Paciente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Endereco",
                columns: new[] { "Id", "CEP", "Cidade", "Estado", "Numero", "Regiao", "Rua" },
                values: new object[,]
                {
                    { 1, "89026720", "Blumenau", "SC", "158", "Progresso", "Rua Oscar Wippel" },
                    { 2, "89045720", "São Paulo", "SP", "18", "Progresso", "Rua Barbosa" }
                });

            migrationBuilder.InsertData(
                table: "Pessoa",
                columns: new[] { "Id", "Email", "EnderecoId", "Nome", "Sexo", "Telefone" },
                values: new object[,]
                {
                    { 1, "guga@gmail.com", 1, "Gustavo Soares", "Masculino", "(47) 98916-7557" },
                    { 2, "musser@gmail.com", 2, "Richard Musser", "Feminino", "(55) 99916-7557" }
                });

            migrationBuilder.InsertData(
                table: "Paciente",
                columns: new[] { "Id", "Alergia", "Limitacao", "PessoaId", "TipoSanquineo" },
                values: new object[,]
                {
                    { 1, "Nenhuma", "Nenhuma", 1, null },
                    { 2, "Alergia a Dipirona", "Cadeirante", 2, null }
                });

            migrationBuilder.InsertData(
                table: "Agenda",
                columns: new[] { "Id", "DataConsulta", "Descricao", "PacienteId", "Titulo" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 5, 20, 9, 15, 0, 0, DateTimeKind.Unspecified), "Checkup geral", 1, "Urologista" },
                    { 2, new DateTime(2023, 4, 19, 9, 15, 0, 0, DateTimeKind.Unspecified), "Remoção de pedra no Rim", 2, "Cigurgia" }
                });

            migrationBuilder.InsertData(
                table: "Prontuario",
                columns: new[] { "Id", "DataAbertura", "PacienteId" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), 1 },
                    { 2, new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Local), 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Agenda_PacienteId",
                table: "Agenda",
                column: "PacienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_PessoaId",
                table: "Paciente",
                column: "PessoaId");

            migrationBuilder.CreateIndex(
                name: "IX_Pessoa_EnderecoId",
                table: "Pessoa",
                column: "EnderecoId");

            migrationBuilder.CreateIndex(
                name: "IX_Prontuario_PacienteId",
                table: "Prontuario",
                column: "PacienteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Agenda");

            migrationBuilder.DropTable(
                name: "Prontuario");

            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "Pessoa");

            migrationBuilder.DropTable(
                name: "Endereco");
        }
    }
}
