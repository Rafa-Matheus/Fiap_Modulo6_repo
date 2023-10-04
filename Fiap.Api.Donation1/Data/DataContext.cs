using Fiap.Api.Donation1.Models;
using Microsoft.EntityFrameworkCore;

namespace Fiap.Api.Donation1.Data
{
    public class DataContext : DbContext
    {

        // Para vincular o Model com o Banco de Dados:
        public DbSet<TipoProdutoModel> TipoProdutos { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }

        public DataContext(DbContextOptions options) : base(options)
        {

        }

        protected DataContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TipoProdutoModel>().HasData(
                    new TipoProdutoModel(1, "Celular", "Descrição para celular"),
                    new TipoProdutoModel(2, "TVs", "Descrição para TV"),
                    new TipoProdutoModel(3, "Ar-condicionado", "Descrição para ar-condicionado")
                );

            modelBuilder.Entity<UsuarioModel>().HasData(
                    new UsuarioModel(1, "rafael@email.com", "Super Admin", "123456", "admin"),
                    new UsuarioModel(2, "carla@email.com", "Carla Oliveira", "123456", "admin"),
                    new UsuarioModel(3, "luciane@email.com", "Luciane Oliveira", "123456", "admin")
                );

            base.OnModelCreating(modelBuilder);
        }

    }
}
