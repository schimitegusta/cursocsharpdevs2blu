using Devs2Blu.ProjetosAula.AtividadeMVC.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.AtividadeMVC.Models
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Mapeamento de Relacionamento
            modelBuilder.Entity<Filme>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Filmes)
                .HasForeignKey(p => p.CategoriaId);

            // Seed
            modelBuilder.Entity<Categoria>()
                .HasData(
                new { Id = 1, Nome = "Terror" },
                new { Id = 2, Nome = "Aventura" },
                new { Id = 3, Nome = "Ficção Científica" }
                );

            modelBuilder.Entity<Filme>()
                .HasData(
                new { Id = 1, Nome = "Rec", Nota = 9, CategoriaId = 1 },
                new { Id = 2, Nome = "Jumanji", Nota = 1, CategoriaId = 2 },
                new { Id = 3, Nome = "Avatar", Nota = 7, CategoriaId = 3 }
                );

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Filme> Filme { get; set; }
        #endregion
    }
}
