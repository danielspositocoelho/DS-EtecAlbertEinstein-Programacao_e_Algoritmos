using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diagonais
{
    class Program
    {
        static void Main(string[] args)
        {/*Classe XdeUm
            Declare uma matriz de char de 5 x 5. 
            Preencha com 1 as diagonais e com 0 os demais elementos. Escreva ao final a matriz obtida.*/

           
            int[,] matriz = new int [5,5];
            for (int i = 0; i < matriz.GetLength(0); i++) // método GetLength pega a length da dimensao especifica da array
            {
                for (int y = 0; y < matriz.GetLength(1); y++)
                {
                    if (y == i ||y+i==matriz.GetLength(0)-1)
                    {
                        matriz[i,y] = 1;
                        Console.Write("|" + matriz[i,y] + "| ");
                    }
                    else
                    {
                        matriz[i, y] = 0;
                        Console.Write("|"+matriz[i, y] + "| ");
                    }
                }
                Console.WriteLine("");
            }
            Console.ReadKey();

        }
    }
}
