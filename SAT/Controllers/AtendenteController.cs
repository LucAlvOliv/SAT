using Controllers.Base;
using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    class AtendenteController : IBaseController<Atendente>
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(Atendente entity)
        {
            contexto.Atendente.Add(entity);
            contexto.SaveChanges();
        }

        public Atendente BuscarPorID(int id)
        {
            return contexto.Atendente.Find(id);
        }

        public void Editar(Atendente entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Atendente usu = BuscarPorID(id);

            if (usu != null)
            {
                contexto.Atendente.Remove(usu);

                contexto.SaveChanges();
            }
        }

        public IList<Atendente> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Atendente> ListarTodos()
        {
            throw new NotImplementedException();
        }
    }
}
