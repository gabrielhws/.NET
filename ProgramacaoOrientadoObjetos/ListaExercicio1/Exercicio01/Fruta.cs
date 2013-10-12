using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Fruta
    {
        private String nomeFruta;
        private int caloriasPorGrama;
        private int gramas;

        //Construtor com 3 parâmetros
        public Fruta(String nome, int g, int c)
        {
            this.nomeFruta = nome;
            this.gramas = g;
            this.caloriasPorGrama = c;
        }

        //Métodos get e set
        public String NomeFruta
        {
            get { return nomeFruta; }
            set { nomeFruta = value; }
        }
        public int CaloriasPorGrama
        {
            get { return caloriasPorGrama; }
            set { caloriasPorGrama = value; }
        }
        public int Gramas
        {
            get { return gramas; }
            set { gramas = value; }
        }

        //Imprime os dados da fruta

        public void ImprimeFruta()
        {
            Console.WriteLine("Fruta: " + nomeFruta);
            Console.WriteLine("Peso: " + gramas);
            Console.WriteLine("Calorias: " + caloriasPorGrama);

        }
    }
}
