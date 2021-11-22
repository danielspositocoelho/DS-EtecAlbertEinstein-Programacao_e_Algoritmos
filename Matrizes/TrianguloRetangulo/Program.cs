using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianguloRetangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            /*TrianguloRetangulo
            Declare uma matriz de char de 6 x 6, e desenhe um triangulo retângulo conforme exemplo: Exiba a matriz*/

            //HÁ UM BUG AQUI, PRECISA ARRUMAR
            char continuar = 's';
            do
            {               
                    Console.WriteLine("Qual é a largura do triangulo retângulo desejado?");
                    int largura = int.Parse(Console.ReadLine());

                    Console.WriteLine("Qual é a altura da triangulo retângulo desejado?");
                    int altura = int.Parse(Console.ReadLine());

                char[,] piramide = new char[altura, largura];
                for (int i=0; i<piramide.GetLength(0); i++)
                {
                    for (int y = 0; y < piramide.GetLength(1); y++)
                    {
                        if (y <= i)
                            piramide[i, y] = '*';
                    }
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
