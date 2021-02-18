using Microsoft.EntityFrameworkCore;
using CadastroCliente.Models;

namespace CadastroCliente.Data
{
    public class MvcContext : DbContext
    {
        public DbSet<Cliente> Clientes { get; set; }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=mysqlteste;user=root;password=teste");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Cliente>(entity =>
            {
                entity.HasKey(e => e.ID);
                entity.Property(e => e.Nome);
                // entity.Property(e => e.DataNascimento);
                // entity.Property(e => e.Sexo);
                // entity.Property(e => e.Cep);
                // entity.Property(e => e.Endereco);
                // entity.Property(e => e.Numero);
                // entity.Property(e => e.Complemento);
                // entity.Property(e => e.Bairro);
                // entity.Property(e => e.Estado);
                // entity.Property(e => e.Cidade);
            });
        }
    }
}