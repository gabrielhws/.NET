using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        [Column("id", TypeName = "bigint")]
        public long Id { get; set; }
        [Column("titulo", TypeName="varchar")]
        public String Titulo { get; set; }
        [Column("valor", TypeName="double")]
        public Double Valor { get; set; }
        [Column("EditoraId", TypeName = "bigint")]
        [ForeignKey("id")]
        public Editora Editora { get; set; }

        public Livro() { }
    }
}