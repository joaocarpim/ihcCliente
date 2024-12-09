using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ihcCliente.Models;

namespace ihcCliente.Data
{
    public class ihcClienteContext : DbContext
    {
        public ihcClienteContext(DbContextOptions<ihcClienteContext> options)
            : base(options)
        {
        }

        public DbSet<ihcCliente.Models.Cliente> Cliente { get; set; } = default!;
        public DbSet<ihcCliente.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<ihcCliente.Models.Produto> Produto { get; set; } = default!;
        public DbSet<ihcCliente.Models.ItemVenda> ItemVenda { get; set; } = default!;
        public DbSet<ihcCliente.Models.Venda> Venda { get; set; } = default!;


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configuração para a propriedade Preco em Produto
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasColumnType("decimal(18, 2)"); // Define a precisão como 18 e a escala como 2

            // Configuração para a propriedade PrecoUnitario em ItemVenda
            modelBuilder.Entity<ItemVenda>()
                .Property(i => i.PrecoUnitario)
                .HasColumnType("decimal(18, 2)"); // Define a precisão como 18 e a escala como 2

            base.OnModelCreating(modelBuilder);

            // Configuração para a entidade Venda
            modelBuilder.Entity<Venda>()
                .Property(v => v.TotalVenda)
                .HasPrecision(18, 2); // Define a precisão (18 dígitos) e a escala (2 casas decimais)

            // Configuração para a entidade Produto, se necessário
            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasPrecision(18, 2); // Define a precisão e escala do preço do produto
        }
    }
}