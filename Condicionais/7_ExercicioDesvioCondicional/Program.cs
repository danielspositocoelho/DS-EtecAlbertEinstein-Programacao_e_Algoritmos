using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_ExercicioDesvioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ParOuImpar - Elabore um programa que verifique se o numero digitado e par ou impar. Use o comando % que retorna o resto de uma divisão. */
            Console.WriteLine("Informe o primeiro número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1%2==0)
            {
                Console.WriteLine("O número " + num1 + " é par");
            }
            else
            {
                Console.WriteLine("O número " + num1 + " é impar");
            }
            Console.ReadKey();

        }
    }
}
