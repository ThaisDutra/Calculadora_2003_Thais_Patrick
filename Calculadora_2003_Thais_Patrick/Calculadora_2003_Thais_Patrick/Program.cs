using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_2003_Thais_Patrick
{
    class Program
    {
        static long Fatorial(int n)
        {

            if (n <= 0)
                return 1;
            else return n * Fatorial(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("resultado");
            Console.ReadLine();
            int[] val = new int[5] { 1, 2, 3, 4, 5 };
            int resultado = Somar(val);
            for (int i = 0; i <= 6; i++)
            {

                Console.WriteLine("{0} ! = {1}", i, Fatorial(i));
            }
            Console.ReadLine();
            
            Console.WriteLine(Soma(10, 20));
            Console.ReadLine();
            Console.WriteLine(Potenciacao(4, 2));
            Console.ReadLine();
            Console.WriteLine(Raiz(256));
            Console.ReadLine();
        }
        public static int Soma(int n1, int n2)
        {
            return n1 + n2;
        }
        public static double Potenciacao(int n3, int n4)
        {
            return Math.Pow(4, 2);
        }

        public static double Raiz(int n5)
        {
            return Math.Sqrt(256);
        }
        static int Somar(int[] valores)
        {
            int resultado = 0;

            for (int i = 0; i < valores.Length; i++)
            {
                resultado += valores[i];
            }
            return resultado;
        }
    }
}
