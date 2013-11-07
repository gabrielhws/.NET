using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    public class EditoraRepository
    {
        private LivrariaContext context = new LivrariaContext();

        public void Adiciona(Editora e)
        {
            context.Editoras.Add(e);
            context.SaveChanges();


        }

        public Editora Busca(int id)
        {
            return context.Editoras.Find(id);
        }

        public List<Editora> BuscaTodas()
        {
            var consulta = from e in context.Editoras
                           select e;
            return consulta.ToList();
        }
    }
}