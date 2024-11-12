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

    }
}
