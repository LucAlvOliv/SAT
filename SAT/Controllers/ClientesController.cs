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
    public class ClientesController : IBaseController<Cliente>
    {
        private Contexto contexto = new Contexto();
        public void Adicionar(Cliente entity)
        {
            contexto.Cliente.Add(entity);
            contexto.SaveChanges();
        }

        public Cliente BuscarPorID(int id)
        {
            return contexto.Cliente.Find(id);
        }

        public void Editar(Cliente entity)
        {
            contexto.Entry(entity).State = System.Data.Entity.EntityState.Modified;
            contexto.SaveChanges();
        }

        public void Excluir(int id)
        {
            Cliente usu = BuscarPorID(id);

            if (usu != null)
            {
                contexto.Cliente.Remove(usu);

                contexto.SaveChanges();
            }
        }

        public IList<Cliente> ListarPorNome(string nome)
        {
            return contexto.Cliente.Where(usu => usu.Nome == nome).ToList();
        }

        public IList<Cliente> ListarTodos()
        {
            return contexto.Cliente.ToList();
        }

        public Cliente BuscarPorCpf(string cpf)
        {
            return contexto.Cliente.Where(usu => usu.CPF == cpf).ToList().FirstOrDefault();
        }
    }
}
