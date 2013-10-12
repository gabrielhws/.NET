using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo3
{
    public class Editora
    {
        private int EditoraID;

        public int EditoraID1
        {
            get { return EditoraID; }
            set { EditoraID = value; }
        }

        private String nome;

        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private String email;

        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        private ICollection<Livro> livros;

        public ICollection<Livro> Livros
        {
            get { return livros; }
            set { livros = value; }
        }

        public Editora(){ }
    }
}
