using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02
{
    public class Conta
    {
        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        private String titular;

        public String Titular
        {
            get { return titular; }
            set { titular = value; }
        }
        private Double saldo;

        public Double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public Conta(){}

        public Conta(int num, String titular, Double saldo)
        {
            this.Numero = numero;
            this.Titular = titular;
            this.Saldo = saldo;
        }

        public void Credito(Double d)
        {
            
            this.Saldo += d;

        }

        public void Debito(Double d)
        {
            this.Saldo -=d;

        }

        public void ImprimeDadosConta()
        {
            if (Saldo < 0)
            {
                Console.WriteLine("-=- Informações de Conta -=-");
                Console.WriteLine("Número: " + Numero);
                Console.WriteLine("Titular: " + Titular);
                Console.WriteLine("saldo: " + Saldo + " Atenção cliente seu saldo está negativo!");
            }
            else
            {
                Console.WriteLine("-=- Informações de Conta -=-");
                Console.WriteLine("Número: " + Numero);
                Console.WriteLine("Titular: " + Titular);
                Console.WriteLine("saldo: " + Saldo + " Saldo OK");
            }
            
            
        }


    

    }
}
