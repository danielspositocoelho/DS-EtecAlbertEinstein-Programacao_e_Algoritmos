using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_ExercicioDesvioCondicional
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

            int menornum;
            if (numA<numB && numA<numC)
            {
                menornum = numA;
                if (numB < numC)
                {
                    Console.WriteLine(menornum+" "+numB +" "+numC);
                }
                else
                {
                    Console.WriteLine(menornum + " " + numC + " " + numB);
                }
            }
            else if (numB<numC && numB<numA)
            {
                menornum = numB;
                if(numA < numC)
                {
                    Console.WriteLine(menornum + " " + numA + " " + numC);
                }
                else
                {
                    Console.WriteLine(menornum + " " + numC + " " + numA);
                }
            }
            else if (numC<numA && numC<numB)
            {
                menornum = numC;
                if (numA < numB)
                {
                    Console.WriteLine(menornum + " " + numA + " " + numB);
                }
                else
                {
                    Console.WriteLine(menornum + " " + numB + " " + numA);
                }
            }
                        Console.ReadKey();
        }
    }
}
