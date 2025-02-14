using AlmoxarifadoBackAPI.Models;
using Microsoft.EntityFrameworkCore; 

namespace AlmoxarifadoBackAPI.Repositorio
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categoria>().HasKey(c=>c.Codigo);
            modelBuilder.Entity<Categoria>().Property(c => c.Codigo).ValueGeneratedOnAdd();

            modelBuilder.Entity<Produto>().HasKey(c => c.IdProd);
            modelBuilder.Entity<Produto>().Property(c => c.IdProd).ValueGeneratedOnAdd();

            modelBuilder.Entity<Fornecedor>().HasKey(c => c.IdForn);
            modelBuilder.Entity<Fornecedor>().Property(c => c.IdForn).ValueGeneratedOnAdd();

            modelBuilder.Entity<Secretaria>().HasKey(c => c.IdSec);
            modelBuilder.Entity<Secretaria>().Property(c => c.IdSec).ValueGeneratedOnAdd();

            modelBuilder.Entity<Entrada>().HasKey(c => c.IdEnt);
            modelBuilder.Entity<Entrada>().Property(c => c.IdEnt).ValueGeneratedOnAdd();

            modelBuilder.Entity<Saida>().HasKey(c => c.IdSaid);
            modelBuilder.Entity<Saida>().Property(c => c.IdSaid).ValueGeneratedOnAdd();

            modelBuilder.Entity<ItenEntrada>().HasKey(c => c.IdIEnt);
            modelBuilder.Entity<ItenEntrada>().Property(c => c.IdIEnt).ValueGeneratedOnAdd();

            modelBuilder.Entity<ItenSaida>().HasKey(c => c.IdISaid);
            modelBuilder.Entity<ItenSaida>().Property(c => c.IdISaid).ValueGeneratedOnAdd();

        }
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Fornecedor> Fornecedor { get; set; }
        public DbSet<Secretaria> Secretaria { get; set; }
        public DbSet<Entrada> Entrada { get; set; }
        public DbSet<Saida> Saida { get; set; }
        public DbSet<ItenEntrada> ItenEntrada { get; set; }
        public DbSet<ItenSaida> ItenSaida { get; set; }


    }

    
    
    
}
