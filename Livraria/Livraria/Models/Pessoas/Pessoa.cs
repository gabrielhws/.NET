using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Livraria.Models.Pessoas
{
    [Table("Pessoas")]
    public class Pessoa
    {
        [Key]
        [Column("id", TypeName = "bigint")]
        public int Id { get; set; }
        [Column("nome", TypeName = "varchar")]
        [StringLength(20,MinimumLength=3, ErrorMessage="O Campo Nome deve possuir no mínimo 3 caracteres")]
        public String Nome { get; set; }
        [Column("sobrenome", TypeName = "varchar")]
        [StringLength(300, MinimumLength = 3, ErrorMessage = "O Campo Sobrenome deve possuir no mínimo 3 caracteres")]
        public String Sobrenome { get; set; }
        [Column("bio", TypeName = "text")]
        public String Bio { get; set; }
        [Column("EndId", TypeName = "bigint")]
        [ForeignKey("EndId")]
        public long EndId { get; set; }
        public  Endereco Endereco { get; set; }
        public String Email { get; set; }
        public Uri Blog { get; set; }
        public Uri Facebook { get; set; }
        public Uri Twitter { get; set; }
        public Uri GooglePlus { get; set; }
        public Uri Linkedin { get; set; }

        public Pessoa() { }
    }
}