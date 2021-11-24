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
            char continuar = 's';
            char[,] tabuleiro = new char[3, 3];

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

                bool continua = true;
                Console.WriteLine("Escolha o lugar em que deseja colocar o 0 no tabuleiro. Não é permitido colocar peças em lugares já ocupados. Seja legal :-)");
                while (continua == true)
                {
                    continua = false;
                    Console.WriteLine("Jogador 1 [O] - Informe a linha:");
                    int linha = int.Parse(Console.ReadLine());
                    Console.WriteLine("Jogador 1 [O] - Informe a coluna:");
                    int coluna = int.Parse(Console.ReadLine());

                    for (int i = 0; i < tabuleiro.GetLength(0); i++)
                    {
                        for (int z = 0; z < tabuleiro.GetLength(1); z++)
                        {
                            if (i == linha - 1 && z == coluna - 1)
                                tabuleiro[i, z] = 'O';

                            Console.Write("|" + tabuleiro[i, z] + "| ");
                        }
                        Console.WriteLine("");
                    }

                    Console.WriteLine("Jogador 2 [X] - Informe a linha:");
                    linha = int.Parse(Console.ReadLine());
                    Console.WriteLine("Jogador 2 [X] - Informe a coluna:");
                    coluna = int.Parse(Console.ReadLine());

                    for (int i = 0; i < tabuleiro.GetLength(0); i++)
                    {
                        for (int z = 0; z < tabuleiro.GetLength(1); z++)
                        {
                            if (i == linha - 1 && z == coluna - 1)
                                tabuleiro[i, z] = 'X';

                            Console.Write("|" + tabuleiro[i, z] + "| ");
                        }
                        Console.WriteLine("");
                    }

                    for (int i = 0; i < tabuleiro.GetLength(0); i++)
                    {
                        for (int z = 0; z < tabuleiro.GetLength(1); z++)
                        {
                            if (tabuleiro[i, z] != 'O' && tabuleiro[i, z] != 'X')
                                continua = true;
                        }
                        Console.WriteLine("");
                    }
                }
                Console.WriteLine("Deseja continuar? Digite 's' para repetir e qualquer outra coisa para sair");
            } while (continuar == 's');

        }
    }
}
