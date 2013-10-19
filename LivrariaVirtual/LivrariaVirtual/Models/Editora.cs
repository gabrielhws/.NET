using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LivrariaVirtual.Models
{
    [Table("Editoras")]
    public class Editora
    {
        [Key]
        public int Id {get;set; }

        [Column("nome", TypeName="varchar")]
        [StringLength(300, MinimumLength = 2)]
        [Required]
        public String Nome { get; set; }

        [Column("email",TypeName="varchar")]
        [Required]
        public String Email { get; set; }
        public ICollection<Livro> Livros { get; set; }

        public Editora() { }
    }
}