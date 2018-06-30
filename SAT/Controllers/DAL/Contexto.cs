using Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers.DAL
{
    class Contexto : DbContext
    {
        public Contexto() : base("strConn")
        {
            // PADRAO (se nao existir base de dados, cria)
            //Database.SetInitializer(new CreateDatabaseIfNotExists<Contexto>());

            // Apaga e recria a base toda vez que o projeto é executado
            //Database.SetInitializer(new DropCreateDatabaseAlways<Contexto>());

            // Apaga e recria a base de dados se houver alteracoes nas modelos
            //Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Contexto>());
        }
        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Atendimento> AtendimentoCliente { get; set; }

        public DbSet<Atendente> Atendente { get; set; }
    }
}
