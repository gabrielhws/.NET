using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    public class LivroRepository
    {
        private LivrariaContext context = new LivrariaContext();

        public void Adiciona(Livro l)
        {
            context.Livros.Add(l);
            context.SaveChanges();

 
        }

        public Livro Busca(int id)
        {
            return context.Livros.Find(id);
        }

        public List<Livro> BuscaTodas()
        {
            var consulta = from e in context.Livros
                           select e;
            return consulta.ToList();
        }
    }
}