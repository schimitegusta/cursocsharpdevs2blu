using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjetoSaude.Infra.Data.Migrations
{
    /// <inheritdoc />
    public partial class DataNascADD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TipoSanquineo",
                table: "Paciente",
                newName: "TipoSanguineo");

            migrationBuilder.AddColumn<DateTime>(
                name: "DataNasc",
                table: "Pessoa",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 1,
                column: "TipoSanguineo",
                value: "AB+");

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 2,
                column: "TipoSanguineo",
                value: "A+");

            migrationBuilder.UpdateData(
                table: "Pessoa",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataNasc",
                value: new DateTime(2003, 11, 2, 1, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Pessoa",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataNasc",
                value: new DateTime(2003, 12, 22, 12, 15, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Prontuario",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataAbertura",
                value: new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Prontuario",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataAbertura",
                value: new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Local));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DataNasc",
                table: "Pessoa");

            migrationBuilder.RenameColumn(
                name: "TipoSanguineo",
                table: "Paciente",
                newName: "TipoSanquineo");

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 1,
                column: "TipoSanquineo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Paciente",
                keyColumn: "Id",
                keyValue: 2,
                column: "TipoSanquineo",
                value: null);

            migrationBuilder.UpdateData(
                table: "Prontuario",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataAbertura",
                value: new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "Prontuario",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataAbertura",
                value: new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}
