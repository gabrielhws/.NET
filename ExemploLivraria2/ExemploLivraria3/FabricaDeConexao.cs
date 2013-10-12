using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploLivraria3
{
    class FabricaDeConexao
    {
        private String usaConn;

        public String UsaConn
        {
            get { return usaConn; }
            set { usaConn = value; }
        }

        public FabricaDeConexao() { }



        public OdbcConnection CriarConexao()
        {
            string driver = @"SQL Server";
            string servidor = @"CADBH996";
            string dataBase = @"livraria";
            string usuario = @"sa";
            string senha = @"sa";
            string t_Connection = @"yes";

            StringBuilder connectionString = new StringBuilder();
            
            connectionString.Append("driver=");
            connectionString.Append(driver);
            connectionString.Append(";server=");
            connectionString.Append(servidor);
            connectionString.Append(";database=");
            connectionString.Append(dataBase);
            connectionString.Append(";Trusted_Connection=");
            connectionString.Append(t_Connection);

            return new OdbcConnection(connectionString.ToString());
        }

        public void AbrirConexao()
        {
            
        }

      
    }
}
