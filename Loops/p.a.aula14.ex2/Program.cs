using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p.a.aula14.ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um Programa que escreva na tela os números pares de 1 até 20
            int contador = 0;
            while(contador<20)
            {
                contador++;
                if(contador % 2 == 0)
                {
                    Console.WriteLine(contador);
                }
            }
            Console.ReadKey();
        }
    }
}
