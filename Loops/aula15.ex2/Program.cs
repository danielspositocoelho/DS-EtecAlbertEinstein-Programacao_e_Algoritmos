using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula15.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um Programa que escreva todos os múltiplos de 7, do intervalo de 1 a 1500.
            int multiplo = 0;
            int i = 0;
            do
            {
                multiplo += 7;
                i++;
                Console.WriteLine(multiplo);
            }
            while(i<1500);
            Console.ReadKey();
        }
    }
}
