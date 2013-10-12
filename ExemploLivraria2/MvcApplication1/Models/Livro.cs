using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    //Define a tabela para o qual a classe é mapeada.
    [Table("livros")]
    public class Livro
    {
        
        private int livroId;
        
        [Key]
        public int LivroId
        {
            get { return livroId; }
            set { livroId = value; }
        }
        
        private String titulo;

        [Required]
        //ColumnAttribute Define o nome e o tipo da coluna no banco de dados da propriedade mapeada.
        [Column("titulo", TypeName ="varchar")]
        //Define o tamanho mínimo e máximo permitido para o campo string.
        [MinLength(10, ErrorMessage="Tamanho mínimo do título: 10")]

        //Define o tamanho mínimo permitido para um array ou string.
        [MaxLength(255, ErrorMessage="Tamanho Máximo do tíluto: 255")]
        public String Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        
        private Double preco;

        [Column("preco", TypeName = "float")]
        public Double Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        
        
        private Editora editora;

        /*ForeignKeyAttribute - é adicionado a propriedade para especificar a propriedade que define a
chave estrangeira do relacionamento.*/
        [ForeignKey ("Editora")]
        public long editoraId;

        [Column("editoraID", TypeName = "bigint")]
        public Editora Editora
        {
            get { return editora; }
            set { editora = value; }
        }
        

        private Pessoa autor;

        /*InversePropertyAttribute Indica a propriedade que define o relacionamento. Esta anotação
é utilizada quando temos múltiplos relacionamentos do mesmo tipo. */
        [InverseProperty("LivrosPublicados")]
        public Pessoa Autor
        {
            get { return autor; }
            set { autor = value; }
        }

        private Pessoa revisor;

        [InverseProperty("LivrosRevisados")]
        public Pessoa Revisor
        {
            get { return revisor; }
            set { revisor = value; }
        }

        public Livro() { }
    }
}