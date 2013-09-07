using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrimeiraAPP_MVC4.Models
{
    public class UsuarioModel
    {
        [DisplayName("Primeiro Nome")]
        [StringLength(50, ErrorMessage="No campo nome é permitido no máximo 50 caracteres")]
        public string nome { get; set; }
        [Required]

        public string sobrenome { get; set; }
        public string endereco { get; set; }
        [StringLength(50)]
        [Required (ErrorMessage="Informe o e-mail")]

        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*", ErrorMessage="E-mail Inválido")]
        public string email { get; set; }

        [DataType(DataType.Date)]
        public DateTime nascimento { get; set; }


    }
}