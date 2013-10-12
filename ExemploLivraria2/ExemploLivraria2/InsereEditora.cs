using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLivraria3
{
    class InsereEditora
    {
        static void Main(string[] args)
        {
          
            String comandoEditora = @"insert into livraria.dbo.Editoras (nome, email) values (?,?)";

            OdbcCommand comando = new OdbcCommand(comandoEditora, conexao);

            Console.WriteLine("Nome de Editora: ");
            String nomeEditora = Console.ReadLine();

            Console.WriteLine("E-mail da Editora: ");
            String emailEditora = Console.ReadLine();

            comando.Parameters.AddWithValue("@nome", nomeEditora);
            comando.Parameters.AddWithValue("@email", emailEditora);

            conexao.Open();
            comando.ExecuteNonQuery();
            conexao.Close();
        }
    }
}
