using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia uma matriz 10 x 10 e escreva a localização (linha e a coluna) do maior valor*/

            Random gerador = new Random();
            int[,] matriz = new int[10, 10];
            int maior = 0;

            for (int i=0; i<10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matriz[i,j] = gerador.Next(1, 200);
                    Console.Write(matriz[i, j] +"  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            for (int i=0; i<10; i++)
            {
                for (int j = 0; j < 10-1; j++)
                {
                    if(matriz[i, j] > matriz[i, j+1] && matriz[i,j]>maior)
                    {
                        maior = matriz[i, j];
                    }
                    else if (matriz[i, j+1]>maior)
                    {
                        maior = matriz[i, j + 1];
                    }
                }
            }

            Console.WriteLine("O maior número é " + maior);
            Console.ReadKey();

        }
    }
}
