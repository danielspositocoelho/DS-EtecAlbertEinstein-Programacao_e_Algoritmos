using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p.a.aula14.ex._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um Programa que escreva na tela os números de 1 até 20
            int contador = 0;
            while (contador < 20)
            {
                contador++;
                Console.WriteLine(contador);
            }
            Console.ReadKey();
        }
    }
}
