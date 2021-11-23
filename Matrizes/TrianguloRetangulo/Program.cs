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
           char continuar = 's';
            do
            {
                Console.WriteLine("Qual é a largura do triangulo retângulo desejado?");
                int largura = int.Parse(Console.ReadLine());

                Console.WriteLine("Qual é a altura da triangulo retângulo desejado?");
                int altura = int.Parse(Console.ReadLine());

                char[][] piramide = new char[altura][];
                for (int a=0; a<altura;a++)
                {
                    piramide[a] = new char[largura];
                }

                piramide[0] = new char[largura];
                for (int i = 0; i < piramide.Length; i++)
                {
                    for (int y = 0; y < piramide[0].Length; y++)
                    {
                        if (y <= i)
                            piramide[i][y] = '*';
                    }
                }

                for (int i = 0; i < piramide.Length; i++)
                {
                    for (int y = 0; y < piramide[0].Length; y++)
                    {
                        Console.Write(piramide[i][y]);
                    }
                    Console.WriteLine("");
                }

                Console.WriteLine("Deseja Continuar? Digite 's' para sim, qualquer outra coisa para não.");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 's');
        }
    }
}
