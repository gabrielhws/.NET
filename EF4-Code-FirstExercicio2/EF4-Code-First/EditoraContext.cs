using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace EF4_Code_First
{
    class EditoraContext : DbContext
    {
        public DbSet<Editora> Editoras {get; set;}
    }
}
