using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anagrama
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que receba duas palavras e verifique se uma palavra é anagrama da outra.
             * Anagramas são palavras formadas pelas mesmas letras arranjadas de forma diferente. 
             * Ex.: amor-Roma, América-Iracema, rato-ator.*/
            int mesmaLetra=0;
            char continuar = 's';
            do
            {
                Console.WriteLine("Escreva uma palavra: ");
                string palavra1 = Console.ReadLine();

                Console.WriteLine("Escreva uma segunda palavra: ");
                string palavra2 = Console.ReadLine();

                palavra1.ToCharArray();
                palavra2.ToCharArray();
                if (palavra1.Length != palavra2.Length)
                {
                    Console.WriteLine("Essas palavras NÃO são anagramas uma da outra");
                }
                else
                {
                    for (int i = 0; i < palavra1.Length; i++)
                    {
                        for (int y = 0; y < palavra2.Length; y++)
                        {
                            if (palavra1[i] == palavra2[y])
                            {
                                mesmaLetra++;
                            }
                        }
                    }

                    if (mesmaLetra >= palavra1.Length)
                    {
                        Console.WriteLine("Essas palavras SÃO anagramas uma da outra");
                    }
                    else
                    {
                        Console.WriteLine("Essas palavras NÃO são anagramas uma da outra");
                    }
                }
                Console.WriteLine("Deseja continuar? Digite apenas s para sim, qualquer outra coisa para não");
                continuar = char.Parse(Console.ReadLine());
            } while (continuar=='s');
        }
    }
}
