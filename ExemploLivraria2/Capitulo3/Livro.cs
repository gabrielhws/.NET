using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capitulo3
{
    public class Livro
    {
        private int livroId;

        public int LivroId
        {
            get { return livroId; }
            set { livroId = value; }
        }

        private String titulo;

        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private Double preco;

        public Double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        private Editora editora;

        public Editora Editora
        {
            get { return editora; }
            set { editora = value; }
        }

        public Livro() { }



    }
}
