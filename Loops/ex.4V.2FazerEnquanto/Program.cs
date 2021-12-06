using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex._4V._2FazerEnquanto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um Programa que leia um número, multiplique-o por 5,
            //mostre o resultado e pergunte se o usuário quer continuar.
            //Se sim, repita o procedimento.

           char continuar;
           
            do
            {
                Console.WriteLine("Escreva um número inteiro. Multiplicaremos ele por 5.");
                int num = int.Parse(Console.ReadLine());
                int resultado = num * 5;
                Console.WriteLine("Resultado = " + resultado);
                Console.WriteLine("Quer continuar? Responda 's' para Sim e 'n' para Não");
                continuar = char.Parse(Console.ReadLine());
            }
            while (continuar == 's' || continuar == 'S');

                Console.WriteLine("Programa encerrado");
            Console.ReadKey();
        }
    }
}
