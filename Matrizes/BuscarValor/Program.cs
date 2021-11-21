using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuscarValor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BuscarValor
            Declare uma matriz de inteiros de 20 x 20 e preencha com números aleatórios.
            Receba um valor informado pelo usuário. O programa deverá fazer uma busca desse valor na matriz e, exibir a localização (linha e coluna) de cada uma das ocorrências ou uma mensagem de “não encontrado”.
            Exiba também a matriz.*/
            Random gerador = new Random();
            int[,] matriz = new int[20, 20];
            int num = 0;
            bool encontrado = false;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    matriz[i, j] = gerador.Next(1, 99);
                                                              //consertando alinhamento
                    if (matriz[i,j]<=9)
                    Console.Write(" "+matriz[i, j] + "  ");
                    else
                    Console.Write(matriz[i, j] + "  ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");


            Console.WriteLine("Escreva o número que desejas procurar na matriz: ");
            num = int.Parse(Console.ReadLine());

            Console.WriteLine("Seu número foi encontrado nas seguintes coordenadas da matriz: ");
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    if(matriz[i,j]==num)
                    {
                        encontrado = true;
                        Console.WriteLine("Linha: " + (i+1) + " Coluna: " + (j+1) );
                    }
                }
            }

            if (encontrado==false)
                Console.WriteLine("Seu número não foi encontrado");
            
            Console.ReadKey();
        }
    }
}

