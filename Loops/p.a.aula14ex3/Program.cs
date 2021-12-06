using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p.a.aula14ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gerador = new Random();
            int contador = 1, totalizador = 0;
            while(contador<=10)
            {
                int numero = gerador.Next(100);
                Console.WriteLine(numero);
                totalizador += numero;
                contador++;
            }
            Console.WriteLine("Total " + totalizador);
            Console.ReadKey();
        }
    }
}
