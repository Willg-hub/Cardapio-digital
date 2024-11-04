using Cardapio_digital.Entity.Models;

namespace Cardapio_digital.Entity.Interface
{
    public interface IGrupoRepository
    {
        void Create(Grupo grupo);
        void Update(Grupo grupo);
        List<Grupo> GetAll();

    }
}
