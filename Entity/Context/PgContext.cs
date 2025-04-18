using Microsoft.EntityFrameworkCore;
using Entity.Models;

namespace Entity.Context
{
    public class PgContext : DbContext
    {


        public PgContext(DbContextOptions<PgContext> options) : base(options)
        {
        }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Produto> Produto { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GrupoMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
