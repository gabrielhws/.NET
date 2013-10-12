using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MvcApplication1.Models
{
    public class EditoraContext : DbContext
    {
        private DbSet<Editora> editoras;

        public DbSet<Editora> Editoras
        {
          get { return editoras; }
          set { editoras = value; }
        }

        private DbSet<Livro> livros;

        public DbSet<Livro> Livros
        {
            get { return livros; }
            set { livros = value; }
        }

    }
}