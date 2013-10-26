using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF4_Code_First
{
    public class ListaEditoraComEF
    {
        public static void Main(string[] args)
        {
            using (EditoraContext context = new EditoraContext())
            {
                var consulta = from e in context.Editoras
                               select e;

                foreach (var item in consulta)
                {
                    System.Console.WriteLine("{0}: {1} - {2}",item.Id, item.Nome, 
                        item.Email);
                }
            }
        }
    }
}
