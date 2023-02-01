using Devs2Blu.ProjetosAula.ExercicioFerias.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.ExercicioFerias.Models
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
            modelBuilder.Entity<Noticia>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Noticias)
                .HasForeignKey(p => p.CategoriaId);


            // Seed
            modelBuilder.Entity<Categoria>()
                .HasData(
                new { Id = 1, Nome = "Crime" },
                new { Id = 2, Nome = "Política" },
                new { Id = 3, Nome = "Assédio" },
                new { Id = 4, Nome = "Tecnologia" }
                );

            modelBuilder.Entity<Noticia>()
                .HasData(
                new { Id = 1, Titulo = "Assalto a mão armada em SP infarta mulher.", Descricao = "Mulher se assustou.", CategoriaId = 1 },
                new { Id = 2, Titulo = "Bolsonazistas estão malucos.", Descricao = "Combate ao terrorismo cresce no Brasil.", CategoriaId = 2 },
                new { Id = 3, Titulo = "Blizzard novamente é processada por assédio.", Descricao = "Infelizmente Hearthstone vai de vala.", CategoriaId = 3 },
                new { Id = 4, Titulo = "Elon Musk não 'faz' ele apenas têm dinheiro.", Descricao = "True, não tem jeito.", CategoriaId = 4 }
                );

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Noticia> Noticia { get; set; }

        #endregion
    }
}
