using Devs2Blu.PrimeiroExercicioAPIASPNetCore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.PrimeiroExercicioAPIASPNetCore.Repository.Data
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>()
                .HasData(
                new { Id = 1, Title = "A Aventura das Aventuras", Description = "Filme conta sobre uma aventura das aventuras de Plim Plim", Rating = "GENERAL AUDIENCES. ALL AGES ADMITTED" },
                new { Id = 2, Title = "Plim Plim e o Roubo", Description = "Filme conta sobre um roubo de um banco que Plim Plim efetuou", Rating = "PARENTAL GUIDANCE SUGGESTED. SOME MATERIAL MAY NOT BE SUITABLE FOR CHILDREN" },
                new { Id = 3, Title = "Plim Plim e a Fuga da Prisão", Description = "Apos roubou Plim Plim tenta fugir da prisão", Rating = "NO ONE 17 AND UNDER ADMITTED" }
                );
        }
        public DbSet<Movie> Movies { get; set; }
    }
}
