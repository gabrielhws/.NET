using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LivrariaVirtual.Models
{
    [Table("Livros")]
    public class Livro
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column("titulo", TypeName="varchar")]
        [StringLength(300, MinimumLength=2)]
        public String Título { get; set; }
        [Column("titulo", TypeName="float")]
        public Double Preco { get; set; }
        [ForeignKey("Editora")]
        [Column("EditoraId", TypeName="bigint")]
        public int EditoraId { get; set; }
        public virtual Editora Editora { get; set; }

    }
}