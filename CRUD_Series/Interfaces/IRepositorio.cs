using System.Collections.Generic;

namespace CRUD_Series.Interfaces
{
    public interface IRepositorio<I>
    {
        List<I> Lista();
        I RetornaPorId(int id);
        void Insere (I entidade);
        void Exclui(int id);
        void Atualiza(int id, I entidade);
        int ProximoId();
    }
}