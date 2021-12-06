using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repetidos
{
    class Program
    {
        static void Main(string[] args)
        {
            /*a)	Repetidos
Declare um array de 100 posições, preencha e verifique se existem valores iguais. Escreva os valores que se repetem e quantas vezes ocorre a repetição
*/          char continuar = 's';
            do
            {
                Console.WriteLine("Escreva o tamanho da array desejada");
                int tam = int.Parse(Console.ReadLine());
                int[] cem = new int[tam];
                Random gerador = new Random();
                Console.WriteLine("Aqui está a array randômica gerada: ");
                for (int i = 0; i < cem.Length; i++)
                {
                    cem[i] = gerador.Next(tam * 3);
                    Console.Write(cem[i]+" ");
                }
                Console.WriteLine(Environment.NewLine);
                //linear search

                for (int y = 0; y < cem.Length; y++)
                {
                    int contador = 0;
                    int buffer = cem[y];
                    for (int z = y + 1; z < cem.Length; z++)
                    {
                        if (buffer == cem[z])
                        {
                            contador++;
                        }
                    }
                    if (contador > 0)
                    {
                        Console.WriteLine(buffer + " se repete por " + contador + " vezes.");
                    }
                }

                Console.WriteLine("Deseja continuar? Digite 's' para sim, qualquer outra coisa para não");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar == 's');
        }
    }
}
