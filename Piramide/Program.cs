using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Piramide
{
    class Program
    {
        static void Main(string[] args)
        {
            //Classe Piramide - Declare uma matriz de char de 11 x 6 e desenhe uma pirâmide de * e exiba-a.
            char continuar = 's';
            do
            {
                int largura = 0;
                int altura = 0;
                do
                {
                    Console.WriteLine("Qual é a largura da pirâmide perfeita desejada? (O número precisa ser ímpar)");
                    largura = int.Parse(Console.ReadLine());

                } while (largura % 2 == 0);

                do
                {
                    Console.WriteLine("Qual é a altura da pirâmide perfeita desejada? (O número precisa ser par)");
                    altura = int.Parse(Console.ReadLine());

                } while (altura % 2 != 0);

                
                char[,] piramide = new char[altura, largura];
                int contador = 0;
                for (int i = piramide.GetLength(0)-1; i >= 0; i--)
                {
                    for (int y = 0; y < piramide.GetLength(1); y++)
                    {
                        if (y >= (piramide.GetLength(1)) - contador || y <= -1 + contador)
                            piramide[i, y] = ' ';
                        else
                            piramide[i, y] = '*';
                    }
                    contador++;
                }

                for (int i = 0; i < piramide.GetLength(0); i++)
                {
                    for (int y = 0; y < piramide.GetLength(1); y++)
                    {
                        Console.Write(piramide[i, y]);
                    }
                    Console.WriteLine("");
                }

                Console.WriteLine("Deseja Continuar? Digite 's' para sim, qualquer outra coisa para não.");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 's');
        }
    }
}
