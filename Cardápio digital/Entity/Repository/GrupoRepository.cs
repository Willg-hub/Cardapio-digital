using Cardapio_digital.Entity.Context;
using Cardapio_digital.Entity.Interface;
using Cardapio_digital.Models;

namespace Cardapio_digital.Entity.Repository
{
    public class GrupoRepository : IGrupoRepository
    {
        private readonly PgContext _context;

        public GrupoRepository(PgContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(_context));
        }

        public void Create(Grupo grupo)
        {
            _context.Grupo.Add(grupo);
            _context.SaveChanges();
        }

        public List<Grupo> GetAll()
        {
            return _context.Grupo.ToList();
        }

        public void Update(Grupo grupo)
        {
            _context.Update(grupo);
            _context.SaveChanges();

        }
    }
}
