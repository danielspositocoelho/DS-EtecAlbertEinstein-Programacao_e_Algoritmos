using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare uma matriz de inteiros de 6 x 6, preencha com números aleatórios entre 1 a 100.
            // Conte e escreva quantos valores maiores que 10 ela possui e a matriz.
            Random gerador = new Random();
            int contador = 0;
            int[,] matriz = new int[6, 6];

            for (int i = 0; i <6; i++)
            {
                for (int y = 0; y <6; y++)
                {
                    matriz[i,y] = gerador.Next(1, 15);
                    if (matriz[i,y]>10)
                    {
                        contador ++;
                        Console.Write("|" + matriz[i,y] + "| ");
                    }
                    else
                        Console.Write(matriz[i,y] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Existem " + contador +" elementos maiores que 10 nessa matriz");
            Console.ReadKey();

        }
    }
}
