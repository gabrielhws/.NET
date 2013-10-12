using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Feira
    {
        static void Main(string[] args)
        {

            Fruta umaLrj = new Fruta("Laranja", 50, 30);
            umaLrj.ImprimeFruta();

            Fruta umaBanana = new Fruta("Banana", 10, 5);
            umaBanana.ImprimeFruta();

            Console.ReadKey();
        }
    }
}
