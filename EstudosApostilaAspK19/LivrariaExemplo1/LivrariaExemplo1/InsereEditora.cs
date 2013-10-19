using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaExemplo1
{
    class InsereEditora
    {
        static void Main2(string[] args)
        {
            String Str = @"driver={SQL Server}; server=CADBH996;database=livraria; Trusted_Connection=yes";

            OdbcConnection conexao = new OdbcConnection(Str);

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
