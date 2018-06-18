using Controllers.Base;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class AtendimentoController : IBaseController<Atendimento>
    {
        public void Adicionar(Atendimento entity)
        {
            throw new NotImplementedException();
        }

        public Atendimento BuscarPorID(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Atendimento entity)
        {
            throw new NotImplementedException();
        }

        public void Excluir(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Atendimento> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Atendimento> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
