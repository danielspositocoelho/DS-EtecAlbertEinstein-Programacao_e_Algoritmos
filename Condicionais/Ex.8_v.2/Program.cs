using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._8_v._2
{
    class Program
    {
        static void Main(string[] args)
        {
            /* OrdenarNumeros -Elaborar um programa que leia 3 valores inteiros digitados (representados pelas variáveis numA, numB e numC).
            * O programa deverá apresentar os valores digitados em ordem crescente. Não esqueça que você precisará de uma variável auxiliar, para não perder os valores digitados pelo usuário.*/

            Console.WriteLine("Informe o primeiro número: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número: ");
            int numC = Convert.ToInt32(Console.ReadLine());

            int aux;
            if (numA>numB)
            {
                aux = numA;
                numA = numB;
                numB = aux;
            }
            if(numA>numC)
            {
                aux = numA;
                numA = numC;
                numC = aux;
            }
            if (numB>numC)
            {
                aux = numB;
                numB = numC;
                numC = aux;
            }
            Console.WriteLine(numA + " " + numB + " " + numC);
            Console.ReadKey();
        }
    }
}
