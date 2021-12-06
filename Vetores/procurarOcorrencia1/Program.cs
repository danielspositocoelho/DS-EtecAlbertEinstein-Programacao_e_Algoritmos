using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace procurarOcorrencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*ProcurarPrimeiraOcorrencia
•	        Declare um array de inteiros de 20 posições, preencha com números gerados aleatoriamente. 
            Receba um valor digitado pelo usuário e exiba a primeira posição do array onde este valor foi encontrado ou se ele não foi encontrado e o array.*/

            Random gerador = new Random();
            int[] vetor = new int [20];
            int nao = 0;
            char continuar = 's';

            do
            {
                for (int i = 0; i < vetor.Length; i++)
                {
                    vetor[i] = gerador.Next(40);
                }

                Console.WriteLine("Digite o número que você deseja procurar no vetor");
                int num = int.Parse(Console.ReadLine());

                for (int y = 0; y < vetor.Length; y++)
                {
                    if (vetor[y] == num)
                    {
                        Console.WriteLine("A primeira ocorrência deste termo é na posição {0}", y);
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

            } while (continuar=='s');
        }
    }
}
