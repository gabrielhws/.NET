using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace EF4_Code_First
{
    public class EditoraRepository
    {
        DbContext context;

        public EditoraRepository(DbContext context)
        {
            this.context = context;
        }

        public void Adiciona(Editora e)
        {
            context.Set<Editora>().Add(e);
            context.SaveChanges();

        }

        public Editora Busca(int id)
        {
            return context.Set<Editora>().Find(id);
        }

        public List<Editora> BuscaTodas()
        {
            var consulta = from e in context.Set<Editora>()
                           select e;
            
            foreach (var item in consulta)
            {
                Console.WriteLine("{0}: {1} - {2}", item.Id, item.Nome, item.Email);
            }
            return consulta.ToList();
        }
    }
}
