using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Diagonal
            Declare uma matriz de inteiros de 8x8 e preencha com números aleatórios.
            Some os elementos das diagonais. Apresente a matriz e as somas das diagonais.*/

            Random gerador = new Random();
           
            int soma = 0;
            int[][] matriz = { new int[8], new int[8], new int[8], new int[8], new int[8],
                             new int[8], new int[8], new int[8]};
            for (int i=0; i<matriz.Length; i++)
            {
                for(int y=0; y<matriz.Length; y++)
                {
                    matriz[i][y] = gerador.Next(1, 50);
                    if(y==i)
                    {
                        soma += matriz[i][y];
                        Console.Write("|"+ matriz[i][y] + "| ");
                    }
                    else
                        Console.Write(matriz[i][y] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("A soma da diagonal é igual a " + soma);
            Console.ReadKey();
              

        }
    }
}
