using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LivrariaVirtual.Models
{
    public class LivrariaDigitalContext : DbContext
    {
        public DbSet<Editora> Editoras { get; set; }
        public DbSet<Livro> Livros { get; set; }
    }
}