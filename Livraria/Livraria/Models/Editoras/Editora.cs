using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Livraria.Models
{
    [Table("Editoras")]
    public class Editora
    {
        [Key]
        [Column("id", TypeName="bigint")]
        public long Id { get; set; }

        [Column("nome", TypeName="varchar")]
        [StringLength(300, MinimumLength=3)]
        public String Nome { get; set; }
        [Column("email", TypeName="varchar")]
        public String Email { get; set; }
        public virtual ICollection<Livro> Livros {get; set; }

        public Editora(){}
    }
}