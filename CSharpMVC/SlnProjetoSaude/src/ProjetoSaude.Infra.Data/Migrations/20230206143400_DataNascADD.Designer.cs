﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProjetoSaude.Infra.Data.Context;

#nullable disable

namespace ProjetoSaude.Infra.Data.Migrations
{
    [DbContext(typeof(SQLServerContext))]
    [Migration("20230206143400_DataNascADD")]
    partial class DataNascADD
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Agenda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataConsulta")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("Agenda");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataConsulta = new DateTime(2023, 5, 20, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Checkup geral",
                            PacienteId = 1,
                            Titulo = "Urologista"
                        },
                        new
                        {
                            Id = 2,
                            DataConsulta = new DateTime(2023, 4, 19, 9, 15, 0, 0, DateTimeKind.Unspecified),
                            Descricao = "Remoção de pedra no Rim",
                            PacienteId = 2,
                            Titulo = "Cigurgia"
                        });
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CEP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Numero")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Regiao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rua")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Endereco");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CEP = "89026720",
                            Cidade = "Blumenau",
                            Estado = "SC",
                            Numero = "158",
                            Regiao = "Progresso",
                            Rua = "Rua Oscar Wippel"
                        },
                        new
                        {
                            Id = 2,
                            CEP = "89045720",
                            Cidade = "São Paulo",
                            Estado = "SP",
                            Numero = "18",
                            Regiao = "Progresso",
                            Rua = "Rua Barbosa"
                        });
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Alergia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Limitacao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PessoaId")
                        .HasColumnType("int");

                    b.Property<string>("TipoSanguineo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("PessoaId");

                    b.ToTable("Paciente");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Alergia = "Nenhuma",
                            Limitacao = "Nenhuma",
                            PessoaId = 1,
                            TipoSanguineo = "AB+"
                        },
                        new
                        {
                            Id = 2,
                            Alergia = "Alergia a Dipirona",
                            Limitacao = "Cadeirante",
                            PessoaId = 2,
                            TipoSanguineo = "A+"
                        });
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Pessoa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataNasc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("Pessoa");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataNasc = new DateTime(2003, 11, 2, 1, 15, 0, 0, DateTimeKind.Unspecified),
                            Email = "guga@gmail.com",
                            EnderecoId = 1,
                            Nome = "Gustavo Soares",
                            Sexo = "Masculino",
                            Telefone = "(47) 98916-7557"
                        },
                        new
                        {
                            Id = 2,
                            DataNasc = new DateTime(2003, 12, 22, 12, 15, 0, 0, DateTimeKind.Unspecified),
                            Email = "musser@gmail.com",
                            EnderecoId = 2,
                            Nome = "Richard Musser",
                            Sexo = "Feminino",
                            Telefone = "(55) 99916-7557"
                        });
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Prontuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataAbertura")
                        .HasColumnType("datetime2");

                    b.Property<int>("PacienteId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PacienteId");

                    b.ToTable("Prontuario");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DataAbertura = new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            PacienteId = 1
                        },
                        new
                        {
                            Id = 2,
                            DataAbertura = new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Local),
                            PacienteId = 2
                        });
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Agenda", b =>
                {
                    b.HasOne("ProjetoSaude.Domain.Entities.Paciente", "Paciente")
                        .WithMany("Agenda")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Paciente", b =>
                {
                    b.HasOne("ProjetoSaude.Domain.Entities.Pessoa", "Pessoa")
                        .WithMany("Paciente")
                        .HasForeignKey("PessoaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Pessoa", b =>
                {
                    b.HasOne("ProjetoSaude.Domain.Entities.Endereco", "Endereco")
                        .WithMany("Pessoa")
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Prontuario", b =>
                {
                    b.HasOne("ProjetoSaude.Domain.Entities.Paciente", "Paciente")
                        .WithMany("Prontuario")
                        .HasForeignKey("PacienteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Paciente");
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Endereco", b =>
                {
                    b.Navigation("Pessoa");
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Paciente", b =>
                {
                    b.Navigation("Agenda");

                    b.Navigation("Prontuario");
                });

            modelBuilder.Entity("ProjetoSaude.Domain.Entities.Pessoa", b =>
                {
                    b.Navigation("Paciente");
                });
#pragma warning restore 612, 618
        }
    }
}