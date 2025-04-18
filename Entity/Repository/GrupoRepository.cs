using Microsoft.EntityFrameworkCore;
using Entity.Context;
using Entity.Interface;
using Entity.Models;

namespace Entity.Repository
{
    public class GrupoRepository : IGrupoRepository
    {
        private readonly PgContext _context;

        public GrupoRepository(PgContext context)
        {
            _context = context;
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

        public Grupo VerificaGrupoExistente(int id)
        {
            return _context.Grupo.AsNoTracking().FirstOrDefault(g => g.Id == id);
        }

        public Grupo GetById(int id)
        {
            return _context.Grupo.Include(x=> x.ListaProdutos).Where(x=> x.Id == id).FirstOrDefault();
        }
    }
}
