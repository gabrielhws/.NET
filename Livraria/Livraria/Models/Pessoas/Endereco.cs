using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Livraria.Models.Pessoas
{
    [Table("Enderecos")]
    public class  Endereco
    {
        [Key]
        [Column("EndId", TypeName="bigint")]
        public int EndId { get; set; }
        [Column("rua", TypeName = "varchar")]
        public String Rua { get; set; }
        [Column("numero", TypeName = "varchar")]
        public String Numero { get; set; }
        [Column("complemento", TypeName = "varchar")]
        public String Complemento { get; set; }
        [Column("ap", TypeName = "varchar")]
        public String Ap { get; set; }
        [Column("bairro", TypeName = "varchar")]
        public String Bairro { get; set; }
        [Column("cidade", TypeName = "varchar")]
        public String Cidade { get; set; }
        [Column("uf", TypeName = "char")]
        public String Uf { get; set; }
        [Column("pais", TypeName = "varchar")]
        public String Pais { get; set; }

        public Endereco() { }
    }
}