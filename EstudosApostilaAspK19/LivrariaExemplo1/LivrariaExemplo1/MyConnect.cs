using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LivrariaExemplo1
{
    class MyConnect
    {
        private String strCon;

        public String StrCon
        {
            get { return strCon = @"driver={SQL Server}; server=CADBH996;database=livraria; Trusted_Connection=yes";}
            set { strCon = value; }
        }

        private String consulta;

        public String Consulta
        {
            get { return consulta; }
            set { consulta = value; }
        }


        OdbcConnection conexao = new OdbcConnection();


        public MyConnect()
        {
        
        }
        
     
    }
}
