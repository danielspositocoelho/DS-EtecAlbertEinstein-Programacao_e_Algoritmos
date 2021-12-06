using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impares
{
    class Program
    {
        static void Main(string[] args)
        {
            /*a)	Classe: Impares
	Declare um array de inteiros de 10 posições numéricas, preencha com os 10 primeiros números impares, gerados aleatoriamente, e exiba o array obtido.*/
            char iniciar ='s';
            Random gerador = new Random();
            int[] impares = new int[10];
            int num;

            do
            {
                int i = 0;
                Console.WriteLine("Quer iniciar? Digite s para sim, qualquer outra coisa para não");
                iniciar = char.Parse(Console.ReadLine());

                Console.Write("Essa é a sequência dos 10 primeiros números impares gerados aleatoriamente - ");
                while (i < impares.Length)
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
            } while (iniciar == 's');
        }
    }
}
