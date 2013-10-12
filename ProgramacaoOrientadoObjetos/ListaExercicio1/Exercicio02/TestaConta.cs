using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class TestaConta
    {
        static void Main(string[] args)
        {
            Conta c1 = new Conta(1, "José", 500);
            c1.ImprimeDadosConta();
            c1.Debito(12222);
            c1.ImprimeDadosConta();

            Conta c2 = new Conta(2, "Marcos", 1500);
            c2.ImprimeDadosConta();
            c2.Debito(12222);
            c2.ImprimeDadosConta();

            Conta c3 = new Conta(3, "Maria", 1500);
            c3.ImprimeDadosConta();
            c3.Debito(12222);
            c3.ImprimeDadosConta();

            Console.ReadKey();




        }
    }
}
