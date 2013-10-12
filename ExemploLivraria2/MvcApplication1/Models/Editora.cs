using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    //Define a tabela para o qual a classe é mapeada.
    [Table("Editoras")]
    public class Editora
    {
        private int EditoraID;

        [Key]
        public int EditoraID1
        {
            get { return EditoraID; }
            set { EditoraID = value; }
        }
        

        private String nome;

        //Define que este campo é obrigatório.
        [Required]
        [Column("nome", TypeName="varchar")]
        //Define o tamanho mínimo e máximo permitido para o campo string.
        [StringLength(255, MinimumLength=10)]
        public String Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        

        private String email;

        [Column("email", TypeName="varchar")]
        public String Email
        {
            get { return email; }
            set { email = value; }
        }

        [NotMapped]
        private String ExtraInfo { get; set; }
     
        private ICollection<Livro> livros;

        public ICollection<Livro> Livros
        {
            get { return livros; }
            set { livros = value; }
        }

        public Editora(){ }
    }
}
