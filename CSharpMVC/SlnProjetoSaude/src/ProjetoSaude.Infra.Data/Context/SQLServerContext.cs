using Microsoft.EntityFrameworkCore;
using ProjetoSaude.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSaude.Infra.Data.Context
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Seed
            modelBuilder.Entity<Endereco>()
                .HasData(
                new { Id = 1, Rua = "Rua Oscar Wippel", Numero = "158", CEP = "89026720", Regiao = "Progresso", Cidade = "Blumenau", Estado = "SC" },
                new { Id = 2, Rua = "Rua Barbosa", Numero = "18", CEP = "89045720", Regiao = "Progresso", Cidade = "São Paulo", Estado = "SP" }
                );

            modelBuilder.Entity<Pessoa>()
                .HasData(
                new { Id = 1, Nome = "Gustavo Soares", DataNasc = new DateTime(2003, 11, 02, 01, 15, 00), Sexo = "Masculino", Telefone = "(47) 98916-7557", Email = "guga@gmail.com", EnderecoId = 1 },
                new { Id = 2, Nome = "Richard Musser", DataNasc = new DateTime(2003, 12, 22, 12, 15, 00), Sexo = "Feminino", Telefone = "(55) 99916-7557", Email = "musser@gmail.com", EnderecoId = 2 }
                );

            modelBuilder.Entity<Paciente>()
                .HasData(
                new { Id = 1, TipoSanguineo = "AB+", Limitacao = "Nenhuma", Alergia = "Nenhuma", PessoaId = 1 },
                new { Id = 2, TipoSanguineo = "A+", Limitacao = "Cadeirante", Alergia = "Alergia a Dipirona", PessoaId = 2 }
                );

            modelBuilder.Entity<Agenda>()
                .HasData(
                new { Id = 1, Titulo = "Urologista", Descricao = "Checkup geral", DataConsulta = new DateTime(2023, 05, 20, 09, 15, 00), PacienteId = 1 },
                new { Id = 2, Titulo = "Cigurgia", Descricao = "Remoção de pedra no Rim", DataConsulta = new DateTime(2023, 04, 19, 09, 15, 00), PacienteId = 2 }
                );

            modelBuilder.Entity<Prontuario>()
                .HasData(
                new { Id = 1, DataAbertura = DateTime.Today, PacienteId = 1 },
                new { Id = 2, DataAbertura = DateTime.Today, PacienteId = 2 }
                );
        }

        #region DBSets<Tables>
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Agenda> Agenda { get; set; }
        public DbSet<Prontuario> Prontuario { get; set; }
        #endregion
    }
}
