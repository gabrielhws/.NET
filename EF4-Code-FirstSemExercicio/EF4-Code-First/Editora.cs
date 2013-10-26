using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace EF4_Code_First
{
    [Table("Editoras")]
    public class Editora
    {
        [Key]
        public int Id {get; set;}
        [Column("NomeEditora", TypeName="varchar")]
        [Required]
        [StringLength(300, MinimumLength=3, ErrorMessage="Quantidade de caracteres não compatível com o campo")]
        public String Nome {get; set;}

        [Column("EmailEditora", TypeName="varchar")]
        [Required]
        [StringLength(500, MinimumLength=2, ErrorMessage="Quantidade de caracteres não compatível com o campo")]
        public String Email {get; set;}

    }
}
