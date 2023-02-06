using Devs2Blu.PrimeiraAPIASPNetCore.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Devs2Blu.PrimeiraAPIASPNetCore.API.Models.Data
{
    public class SQLServerContext : DbContext
    {
        public SQLServerContext(DbContextOptions<SQLServerContext> options)
            : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Contact>()
                .HasData(
                new {Id = 1, Name = "Gustavo Soares", Contact1 = "47989167557", Email = "guga@gmail.com"},
                new { Id = 2, Name = "Joarelmo Ricardo", Contact1 = "47998762342", Email = "jorel@gmail.com" },
                new { Id = 3, Name = "Luciana Hulk", Contact1 = "47993841253", Email = "hulk@gmail.com" }
                );
        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
