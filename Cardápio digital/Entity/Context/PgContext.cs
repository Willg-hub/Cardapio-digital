using Cardapio_digital.Models;
using Microsoft.EntityFrameworkCore;

namespace Cardapio_digital.Entity.Context
{
    public class PgContext : DbContext
    {


        public PgContext(DbContextOptions<PgContext> options) : base(options)
        {
        }
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Produto> Produto { get; set; }

    }
}
