using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Livraria.Models.Pessoas;

namespace Livraria.Models
{
    public class LivrariaContext : DbContext
    {
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros{ get; set; }
        public DbSet<Pessoa> Pessoas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }

        public LivrariaContext() { }
    }
}