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
    class AtendimentoController : IBaseController<Atendimento>
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(Atendimento entity)
        {
            contexto.Atendimento.Add(entity);
            contexto.SaveChanges();
        }

        public Atendimento BuscarPorID(int id)
        {
            return contexto.Atendimento.Find(id);
        }

        public void Editar(Atendimento entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Atendimento usu = BuscarPorID(id);

            if (usu != null)
            {
                contexto.Atendimento.Remove(usu);

                contexto.SaveChanges();
            }
        }

        public IList<Atendimento> ListarPorNome(string nome)
        {
            return contexto.Atendimento.Where(usu => usu.Nome == nome).ToList();
        }

        public IList<Atendimento> ListarTodos()
        {
            return contexto.Atendimento.ToList();
        }
    }
}
