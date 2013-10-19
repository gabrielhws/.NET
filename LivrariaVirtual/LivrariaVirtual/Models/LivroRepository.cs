using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrariaVirtual.Models
{
    public class LivroRepository
    {
        private LivrariaDigitalContext context = new LivrariaDigitalContext();

        public void Adiciona(Livro e)
        {
            context.Livros.Add(e);
            context.SaveChanges();
        }

        public Livro Busca(int id)
        {
            return context.Livros.Find(id);

        }

        public List<Livro> BuscaTodas()
        {
            var consulta = from l in context.Livros
                           select l;
            return consulta.ToList();
        }
    }
}