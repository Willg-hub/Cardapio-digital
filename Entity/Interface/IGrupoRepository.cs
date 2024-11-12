using Entity.Models;

namespace Entity.Interface
{
    public interface IGrupoRepository
    {
        void Create(Grupo grupo);
        void Update(Grupo grupo);
        List<Grupo> GetAll();

        Grupo VerificaGrupoExistente(int id);

        Grupo GetById(int id);
    }
}
