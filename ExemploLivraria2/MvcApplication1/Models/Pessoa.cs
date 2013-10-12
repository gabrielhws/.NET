using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class Pessoa
    {

        private int identificador;

        [Key]
        public int Identificador
        {
            get { return identificador; }
            set { identificador = value; }
        }

        private String nome;

        [Column("nome", TypeName="varchar")]
        [MinLength(10, ErrorMessage="Tamanho mínimo do nome: 10")]
        [MaxLength(255, ErrorMessage="Tamanho máximo do nome: 255")]
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private ICollection<Livro> livrosPublicados;

        public ICollection<Livro> LivrosPublicados
        {
            get { return livrosPublicados; }
            set { livrosPublicados = value; }
        }

        private ICollection<Livro> livrosRevisados;

        public ICollection<Livro> LivrosRevisados
        {
            get { return livrosRevisados; }
            set { livrosRevisados = value; }
        }


        public Pessoa(){ }


    }
}