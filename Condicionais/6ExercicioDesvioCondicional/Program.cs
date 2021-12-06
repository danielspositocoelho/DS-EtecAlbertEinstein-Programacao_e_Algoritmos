using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6ExercicioDesvioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolva um programa que leia dois valores inteiros digitados pelo usuário, e apresente a diferença do maior pelo menor.  */
            Console.WriteLine("Informe o primeiro número inteiro: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número inteiro: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1>num2)
            {
                int dif = num1 - num2;
                Console.WriteLine("A diferença do número maior (" + num1 + ") para o menor (" + num2 + ") é de "+ dif);
            }
            else 
            {
                int dif = num2 - num1;
                Console.WriteLine("A diferença do número maior (" + num2 + ") para o menor (" + num1 + ") é de " + dif);
            }
            Console.ReadKey();
        }
    }
}
