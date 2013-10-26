using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EF4_Code_First
{
    public class InsereEditoraComEF
    {
        public static void Main(string[] args)
        {
            using (EditoraContext context = new EditoraContext())
            {
                Editora editora = new Editora();

                System.Console.WriteLine("### Cadastro de Editoras... ###");
                System.Console.WriteLine("Nome da Editora:");
                editora.Nome = Console.ReadLine();
                System.Console.WriteLine("Email da Editora");
                editora.Email = Console.ReadLine();

                context.Editoras.Add(editora);
                context.SaveChanges();

            }
            
        }
    }
}
