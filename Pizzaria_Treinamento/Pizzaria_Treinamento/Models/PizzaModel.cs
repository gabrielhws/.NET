using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Pizzaria_Treinamento.Models
{
    public class PizzaModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name="Nome da Pizza")]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [Display(Name="Ingredientes")]
        [MinLength(3, ErrorMessage="Precisa de no mínimo 3 caracteres")]
        public string Description { get; set; }

        public PizzaModel() { }

    }
}