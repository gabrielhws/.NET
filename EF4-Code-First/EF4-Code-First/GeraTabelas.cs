using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF4_Code_First
{
    public class GeraTabelas
    {
        static void Main(string[] args)
        {
            using (var context = new EditoraContext())
            {
                Editora editora = new Editora
                {
                    Nome = "Abril",
                    Email = "abril@email.com"
                };
                //Adiciona o estado Added
                context.Editoras.Add(editora);

                //buscando
                Editora editora1 = context.Editoras.Find(1);

                //excluindo
                context.Editoras.Remove(editora);

                context.SaveChanges();
            }//fecha o contexto ao final  
        }
    }
}
