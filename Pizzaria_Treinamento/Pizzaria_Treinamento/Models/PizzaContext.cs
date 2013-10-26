using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pizzaria_Treinamento.Models
{
    public class PizzaContext : DbContext
    {
        public DbSet<PizzaModel> Pizza { get; set; }
    }
}