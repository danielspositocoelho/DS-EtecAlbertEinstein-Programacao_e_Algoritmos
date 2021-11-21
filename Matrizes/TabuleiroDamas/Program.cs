using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabuleiroDamas
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que represente no console um tabuleiro de damas no estado inicial. Utilize uma matriz de char de 8 x 8. 
             * Para representar as pedras brancas utilize o 0 para representar as pedras pretas utilize o *. Para as casas vazias armazene um espaço em branco na matriz.
-----------------
| |0| |0| |0| |0|
-----------------
|0| |0| |0| |0| |
-----------------
| | | | | | | | |
-----------------
| | | | | | | | |
-----------------
| | | | | | | | |
-----------------
|*| |*| |*| |*| |
-----------------
| |*| |*| |*| |*|
-----------------*/
            char[,] tabuleiro = new char[8,8];
            for (int i=0; i<8; i++)
            {
                for (int y=0; y<8; y++)
                {
                    if (i == 0 || i == 7)
                    {
                        if (y % 2 == 0 || y == 0)

                            tabuleiro[i, y] = ' ';
                        else
                            tabuleiro[i, y] = '0';
                    }
                    else if (i == 1 || i == 6)
                    {
                        if (y % 2 == 0 || y == 0)

                            tabuleiro[i, y] = '0';
                        else
                            tabuleiro[i, y] = ' ';
                    }
                    else
                        tabuleiro[i, y] = ' ';
                }
            }

            for (int i = 0; i < 8; i++)
            {
                for (int y = 0; y < 8; y++)
                {
                    Console.Write("|"+tabuleiro[i,y]);
                }
                Console.Write("|");
                Console.WriteLine("\n-----------------");
            }

            Console.ReadKey();
        }
    }
}
