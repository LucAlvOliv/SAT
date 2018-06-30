using Controllers.Base;
using Controllers.DAL;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Controllers
{
    public class AtendimentoController : IBaseController<Atendimento>
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(Atendimento entity)
        {
            contexto.AtendimentoCliente.Add(entity);
            contexto.SaveChanges();
        }

        public Atendimento BuscarPorID(int id)
        {
            return contexto.AtendimentoCliente.Find(id);
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
                contexto.AtendimentoCliente.Remove(usu);

                contexto.SaveChanges();
            }
        }

        public IList<Atendimento> ListarPorNome(string nome)
        {
            return contexto.AtendimentoCliente.Where(usu => usu.Nome == nome).ToList();
        }
        public IList<Atendimento> ListarPorCpf(string cpf)
        {
            return contexto.AtendimentoCliente.Where(usu => usu.CPF == cpf).ToList();
        }
        public IList<Atendimento> ListarPorCodigo(string codigo)
        {
            return contexto.AtendimentoCliente.Where(usu => usu.CodCliente == codigo).ToList();
        }
        public IList<Atendimento> ListarPorPlano(string plano)
        {
            return contexto.AtendimentoCliente.Where(usu => usu.Plano == plano).ToList();
        }

        public IList<Atendimento> ListarTodos()
        {
            return contexto.AtendimentoCliente.ToList();
        }
    }
}
