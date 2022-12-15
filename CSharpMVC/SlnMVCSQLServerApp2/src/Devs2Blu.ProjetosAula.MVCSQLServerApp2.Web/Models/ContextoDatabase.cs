using Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.ProjetosAula.MVCSQLServerApp2.Web.Models
{
    public class ContextoDatabase : DbContext
    {
        public ContextoDatabase(DbContextOptions<ContextoDatabase> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Mapeamento de Relacionamento
            modelBuilder.Entity<Produto>()
                .HasOne(p => p.Categoria)
                .WithMany(c => c.Produtos)
                .HasForeignKey(p => p.CategoriaId);

            modelBuilder.Entity<Categoria>()
                .HasData(
                new { Id = 1, Nome = "Alimentos Não Perecíveis"},
                new { Id = 2, Nome = "Laticínios" },
                new { Id = 3, Nome = "Limpeza"},
                new { Id = 4, Nome = "Bebidas Não Alcoólicas"}
                );

            modelBuilder.Entity<Produto>()
                .HasData(
                new { Id = 1, Nome = "Arroz", Preco = 10.00, Quantidade = 5, CategoriaId = 1 },
                new { Id = 2, Nome = "Feijao", Preco = 10.00, Quantidade = 2, CategoriaId = 1 },
                new { Id = 3, Nome = "Queijo", Preco = 10.00, Quantidade = 6, CategoriaId = 2 },
                new { Id = 4, Nome = "Iorgute", Preco = 10.00, Quantidade = 3, CategoriaId = 2 },
                new { Id = 5, Nome = "Sabao Liquido", Preco = 10.00, Quantidade = 5, CategoriaId = 3 },
                new { Id = 6, Nome = "Multiuso", Preco = 10.00, Quantidade = 5, CategoriaId = 3 },
                new { Id = 7, Nome = "Suco de Limao", Preco = 10.00, Quantidade = 2, CategoriaId = 4 },
                new { Id = 8, Nome = "Coca-cola Zero 2L", Preco = 10.00, Quantidade = 1, CategoriaId = 4 }
                );

            base.OnModelCreating(modelBuilder);
        }

        #region DbSets
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }

        #endregion
    }
}
