using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLivraria3
{
    class ListaEditora
    {
        static void Main(string[] args)
        {
            
            string strConn = @"driver={SQL Server};servidor=CADBH996;database=livraria;t_Connection =yes";
            OdbcConnection conexao = new OdbcConnection(strConn);
  
            String txtListaEditora = "select *from livraria.dbo.Editoras;";
        
            OdbcCommand cmd = new OdbcCommand(txtListaEditora, conexao);


            OdbcDataReader resultado = cmd.ExecuteReader();

                while (resultado.Read())
                {
                    int? id = resultado["id"] as int?;
                    string nomeEditora = resultado["nome"] as string;
                    string emailEditora = resultado["email"] as string;

                    Console.WriteLine("{0} : {1} - {2} \n",id, nomeEditora, emailEditora);
       
                }

                Console.ReadKey();

                
            
        }
    }
}
