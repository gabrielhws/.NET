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
                EditoraRepository repository = new EditoraRepository(context);
                Editora editora = new Editora();

                repository.BuscaTodas();
                
                Console.ReadKey();
            }
        }
    }
}
