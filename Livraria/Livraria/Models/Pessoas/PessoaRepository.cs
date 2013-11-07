using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Models.Pessoas
{
    public class PessoaRepository
    {
        private LivrariaContext context = new LivrariaContext();

        public void Adiciona(Pessoa p)
        {
            context.Pessoas.Add(p);
            context.SaveChanges();


        }

        public Pessoa Busca(int id)
        {
            return context.Pessoas.Find(id);
        }

        public List<Pessoa> BuscaTodas()
        {
            var consulta = from e in context.Pessoas
                           select e;
            return consulta.ToList();
        }
    }
}