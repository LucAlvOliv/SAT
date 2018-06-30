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
    public class AtendimentoController : IBaseController<AtendimentoCliente>
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(AtendimentoCliente entity)
        {
            contexto.AtendimentoCliente.Add(entity);
            contexto.SaveChanges();
        }

        public AtendimentoCliente BuscarPorID(int id)
        {
            return contexto.AtendimentoCliente.Find(id);
        }

        public void Editar(AtendimentoCliente entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            AtendimentoCliente usu = BuscarPorID(id);

            if (usu != null)
            {
                contexto.AtendimentoCliente.Remove(usu);

                contexto.SaveChanges();
            }
        }

        public IList<AtendimentoCliente> ListarPorNome(string nome)
        {
            return contexto.AtendimentoCliente.Where(usu => usu.Nome == nome).ToList();
        }
        public IList<AtendimentoCliente> ListarPorCpf(string cpf)
        {
            return contexto.AtendimentoCliente.Where(usu => usu.CPF == cpf).ToList();
        }
        public IList<AtendimentoCliente> ListarPorCodigo(string codigo)
        {
            return contexto.AtendimentoCliente.Where(usu => usu.CodCliente == codigo).ToList();
        }
        public IList<AtendimentoCliente> ListarPorPlano(string plano)
        {
            return contexto.AtendimentoCliente.Where(usu => usu.Plano == plano).ToList();
        }

        public IList<AtendimentoCliente> ListarTodos()
        {
            return contexto.AtendimentoCliente.ToList();
        }
    }
}
