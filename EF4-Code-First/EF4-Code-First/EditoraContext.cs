using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace EF4_Code_First
{
    public class EditoraContext : DbContext 
    {
        public DbSet<Editora> Editoras { get; set; }
    }
}
