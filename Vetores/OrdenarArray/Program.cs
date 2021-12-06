using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdenarArray
{
    class Program
    {
        static void Main(string[] args)
        {/* Faça um programa que gere e armazene em um array 10 valores gerados randomicamente – e os apresente na ordem em que foram gerados.
          * Ordene os valores e apresente os valores ordenados do menor para o maior. */

            char iniciar = 's';
            Random gerador = new Random();
            int[] impares = new int[10];
            int num;
            bool continuar = false;

            do
            {
                int i = 0;
                Console.Write("Essa é a sequência desordenada dos 10 primeiros números impares gerados aleatoriamente - ");
                while (i < impares.Length)              // gera e apresenta sequencia aleatoria desordenada
                {
                    num = gerador.Next(1000);
                    if (num % 2 != 0)
                    {
                        impares[i] = num;
                        Console.Write(impares[i] + " ");
                        i++;
                    }
                }
                Console.WriteLine("\r\n");

                do     // ordena por BUBBLESORT a mesma sequencia em ordem crescente
                {
                    continuar = false;
                    for (int z =0; z<impares.Length-1; z++)
                    {
                        if (impares[z]>impares[z+1])
                        {
                            int numMaior = impares[z];
                            impares[z] = impares[z + 1];
                            impares[z + 1] = numMaior;

                            continuar = true;
                        }
                    }
                } while (continuar);

                Console.Write("Essa é a mesma sequência acima em ordem crescente - "); // apresenta a sequência ordenada
                for (int y =0; y<impares.Length; y++)
                {
                    Console.Write(impares[y] + " ");
                }
                Console.WriteLine("");

                Console.WriteLine("Quer reiniciar? Digite s para sim, qualquer outra coisa para não");
                iniciar = char.Parse(Console.ReadLine());
            } while (iniciar == 's');
        }
    }
}
