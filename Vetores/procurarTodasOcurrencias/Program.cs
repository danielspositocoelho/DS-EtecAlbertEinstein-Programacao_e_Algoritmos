using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procurarTodasOcurrencias
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declare um array de inteiros de 100 posições, preencha com números gerados aleatoriamente. 
            Receba um valor digitado pelo usuário e exiba todos os índices do array onde ocorre o valor digitado ou se ele não foi encontrado.
            Exiba também o array*/
            Random gerador = new Random();
            int[] vetor = new int[100];
            int nao = 0;
            char continuar = 's';

            do
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = gerador.Next(200);
                }

                Console.WriteLine("Digite o número que você deseja procurar no vetor");
                int num = int.Parse(Console.ReadLine());

                for (int y = 0; y < vetor.Length; y++)
                {
                    if (vetor[y] == num)
                    {
                        Console.WriteLine("Este termo ocorre na posição {0}", y);
                    }
                    else
                    {
                        nao++;
                    }
                }

                if (nao == vetor.Length)
                {
                    Console.WriteLine("O número não foi encontrado");
                }

                for (int z = 0; z < vetor.Length; z++)
                {
                    Console.Write(vetor[z] + " ");
                }

                Console.WriteLine("\nVocê deseja continuar? Digite s para sim, qualquer outra coisa para não");
                continuar = char.Parse(Console.ReadLine());

            } while (continuar == 's');
        }
    }
}
