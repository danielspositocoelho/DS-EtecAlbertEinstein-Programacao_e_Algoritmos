using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabarito
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Declare um array de char com 10 posições onde será armazenado o gabarito da prova (de a até e). Declare uma matriz 100 x 10 que se refere às respostas de 100 alunos.
           * Preencha a matriz com números aleatórios de 1 a 5, sendo que 1 corresponde ao “a” e 5 ao “e” .
           * Comparar as respostas de cada candidato com o gabarito e armazenar um array de inteiros chamado resultado, contendo a pontuação correspondente a cada aluno.
           * Para cada acerto some um ponto. Exiba o gabarito, a matriz e a pontuação.*/

            // char array gabarito 10
            char[] gabarito = new char[] { 'a', 'e', 'c', 'b', 'd', 'c', 'e', 'a', 'a', 'b' };
            Console.WriteLine("Este é o gabarito:\n");
            for (int x = 0; x < gabarito.Length; x++)
            {
                Console.Write(gabarito[x]+" ");
            }

            Console.WriteLine("\n\nEstas são as respostas dados por 100 alunos");
            //random int jagged array respostas 100 x 10 -números aleatórios de 1 a 5, sendo que 1 corresponde ao “a” e 5 ao “e”
            Random gerador = new Random();
            int[,] respostas = new int[100,10];
            for(int i=0; i<respostas.GetLength(0); i++)
            {
                for (int y=0; y<respostas.GetLength(1); y++)
                {
                    respostas[i, y] = gerador.Next(1, 5);
                    Console.Write(respostas[i,y]);
                }
                Console.WriteLine("");
            }
            //comparando linha de respostas com gabarito e armazenando pontuação em int array resultado
            int[] resultado = new int[10];
            for (int i = 0; i < respostas.GetLength(0); i++)
            {
                int pontos = 0;
                Console.Write("A pontuação do aluno {0} foi ", i+1);
                for (int y = 0; y < respostas.GetLength(1); y++)
                {   
                    switch (respostas[i,y])
                    {
                        case 1:
                            if (gabarito[y] == 'a')
                            {
                                resultado[y] = 1;
                            }
                            else
                            {
                                resultado[y] = 0;
                            }
                                break;

                        case 2:
                            if (gabarito[y] == 'b')
                            {
                                resultado[y] = 1;
                            }
                            else
                            {
                                resultado[y] = 0;
                            }
                            break;

                        case 3:
                            if (gabarito[y] == 'c')
                            {
                                resultado[y] = 1;
                            }
                            else
                            {
                                resultado[y] = 0;
                            }
                            break;

                        case 4:
                            if (gabarito[y] == 'd')
                            {
                                resultado[y] = 1;
                            }
                            else
                            {
                                resultado[y] = 0;
                            }
                            break;

                        case 5:
                            if (gabarito[y] == 'e')
                            {
                                resultado[y] = 1;
                            }
                            else
                            {
                                resultado[y] = 0;
                            }
                            break;
                    }
                    if (resultado[y] == 1)
                        pontos++;
                    Console.Write(resultado[y]+" ");
                }
                Console.Write(": Total de {0} pontos\n", pontos);
            }
            Console.ReadLine();
        }
    }
}
