using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoDaVelha
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Jogo da velha: Crie um tabuleiro de jogo da velha, em uma matriz de char de 3x3 e preencha com 0 e X alternadamente, começando sempre por 0.
             * O valor deve ser preenchido no local indicado pelo usuário, o usuário precisa indicar o local informando a linha e a coluna. Por exemplo linha 2, coluna 2.*/
            char continuar = 's';
            char[][] tabuleiro = new char[3][] { new char[3], new char[3], new char[3] };
            do
            {
                for (int x = 0; x < 3; x++)
                {
                    for (int y = 0; y < 3; y++)
                    {
                        Console.Write("| | ");
                    }
                    Console.WriteLine("");
                }

                Console.WriteLine("Escolha o lugar em que deseja colocar o 0 no tabuleiro:");
                for (int jogo=0; jogo<9; jogo++)
                {
                    Console.WriteLine("Informe a linha:");
                    int linha = int.Parse(Console.ReadLine());
                    Console.WriteLine("Informe a coluna:");
                    int coluna = int.Parse(Console.ReadLine());

                    for (int i = 0; i < tabuleiro[0].Length; i++)
                    {
                        for (int z = 0; z < tabuleiro[1].Length; z++)
                        {
                            if (i==linha-1 && z==coluna-1 && tabuleiro[i][z] != '0')
                            {
                                tabuleiro[i][z] = '0';
                                if (z != 2)
                                {
                                    tabuleiro[i][z + 1] = 'X';
                                }
                                else if (z == 2 && i != 2)
                                {
                                    tabuleiro[i + 1][z] = 'X';
                                }
                                else
                                    break;
                            }
                            else if(i == linha - 1 && z == coluna - 1 && tabuleiro[i][z] == '0')
                            {
                                Console.WriteLine("Escolha outra casa, esta ja foi escolhida");
                            }
                            else
                            {
                                tabuleiro[i][z] = ' ';
                            }
                            Console.Write("|" + tabuleiro[i][z] + "| ");
                        }
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("Deseja continuar? Digite 's' para repetir e qualquer outra coisa para sair" );
            } while (continuar == 's');

        }
    }
}
