using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaExemplo1
{
    class Registro
    {

        public static void Main2(string[] args) 
        {
            MyConnect objConn = new MyConnect();

            string Stringconexao = Convert.ToString(objConn.StrCon);

            Console.WriteLine("Teste String de Conexão: ", objConn.StrCon);
            // setença SQL

            String consulta = @"select *from livraria.dbo.livros;";

            // criando um comando odbc


            
            //OdbcCommand comando = new OdbcCommand(consulta, strCon);
        }
    }
}
