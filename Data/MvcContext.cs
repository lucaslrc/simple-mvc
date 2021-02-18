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
                entity.Property(e => e.Nome).IsRequired();
                entity.Property(e => e.Cpf).IsRequired();
                entity.Property(e => e.DataNascimento).IsRequired();
                entity.Property(e => e.Sexo).IsRequired();
                entity.Property(e => e.Cep).IsRequired();
                entity.Property(e => e.Endereco).IsRequired();
                entity.Property(e => e.Numero).IsRequired();
                entity.Property(e => e.Complemento);
                entity.Property(e => e.Bairro).IsRequired();
                entity.Property(e => e.Estado).IsRequired();
                entity.Property(e => e.Cidade).IsRequired();
            });
        }
    }
}