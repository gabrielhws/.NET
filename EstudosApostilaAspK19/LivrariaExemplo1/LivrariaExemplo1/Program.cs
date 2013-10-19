using System.Data.Odbc;
using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace LivrariaExemplo1
{
    class Program
    {
        static void Main(string[] args)
        {
            //String de conexão (Dados do DB)
           String StrCon = @"driver={SQL Server}; server=CADBH996;database=livraria; Trusted_Connection=yes";
           

            Console.WriteLine("Abrindo a conexão ...");
            //Conexão com o banco passando os dados do DB
            OdbcConnection conexao = new OdbcConnection(StrCon);

            //String com o Comando para ir ao DB e fazer algo

            string textoComando = @"insert into livraria.dbo.Livros (titulo, preco, EditoraId)
	    values (?, ?, ?)";

            string consultaSql = @"select * from livraria.dbo.livros";

            Console.WriteLine("Digite o título do livro: ");
            string titulo = Console.ReadLine();

            Console.WriteLine("Digite o preço do livro: ");
            double preco = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite o número do ID da editora deste livro: ");
            int editora = Convert.ToInt32(Console.ReadLine());

            OdbcCommand comando = new OdbcCommand(textoComando, conexao);
            OdbcCommand comandoConsulta = new OdbcCommand(consultaSql, conexao);

            // Atribuindo valores aos parâmetros
            comando.Parameters.AddWithValue("@titulo", titulo);
            comando.Parameters.AddWithValue("@preco", preco);
            comando.Parameters.AddWithValue("@EditoraId", editora);

           
        
            conexao.Open();  //Abre a conexão
            comando.ExecuteNonQuery();  // Executa a Query para inserção

            OdbcDataReader result = comandoConsulta.ExecuteReader();

            titulo = result["nome"] as string;
          
            result.Read();


            conexao.Close();  // Fecha conexão com o banco

        }
    }
  }
