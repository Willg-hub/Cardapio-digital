using Cardapio_digital.Models;
using Microsoft.EntityFrameworkCore;

namespace Cardapio_digital.Entity
{
    public class PgContext : DbContext
    {
        public DbSet<Grupo> Grupo { get; set; }
        public DbSet<Produto> Produto { get; set; }
    }
}
