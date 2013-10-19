using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LivrariaVirtual.Models
{
    public class EditoraRepository
    {
        private LivrariaDigitalContext context = new LivrariaDigitalContext();

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