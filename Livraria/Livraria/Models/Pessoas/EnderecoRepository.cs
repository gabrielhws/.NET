using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Livraria.Models.Pessoas
{
    public class EnderecoRepository
    {
        private LivrariaContext context = new LivrariaContext();

        public void Adiciona(Endereco e)
        {
            context.Enderecos.Add(e);
            context.SaveChanges();


        }

        public Endereco Busca(int EndId)
        {
            return context.Enderecos.Find(EndId);
        }

        public List<Endereco> BuscaTodas()
        {
            var consulta = from e in context.Enderecos
                           select e;
            return consulta.ToList();
        }
    }
}