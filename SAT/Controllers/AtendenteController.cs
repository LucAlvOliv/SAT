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
    public class AtendenteController : IBaseController<Atendente>
    {
        private Contexto context = new Contexto();
        public void Adicionar(Atendente entity)
        {
            context.Atendente.Add(entity);
            context.SaveChanges();
        }

        public Atendente BuscarPorID(int id)
        {
            return context.Atendente.Find(id);
        }

        public void Editar(Atendente entity)
        {
            context.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
        }

        public void Excluir(int id)
        {
            Atendente usu = BuscarPorID(id);

            if (usu != null)
            {
                context.Atendente.Remove(usu);

                context.SaveChanges();
            }
        }

        public IList<Atendente> ListarPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public IList<Atendente> ListarTodos()
        {
            return context.Atendente.ToList();
        }

        public bool VerificarLogin(string login, string senha)
        {
            return context.Atendente.Where(a => a.Usuario == login && a.Senha == senha).Count() > 0;
        }
    }
}
