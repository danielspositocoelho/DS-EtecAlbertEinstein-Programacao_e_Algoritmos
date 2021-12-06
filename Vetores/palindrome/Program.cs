using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            /*•	Faça um programa que receba uma palavra digitada pelo usuário e verifique se essa palavra é palíndrome. 
             * Uma palavra palíndrome é aquela que pode ser lida tanto da direita para a esquerda quanto ao contrário. Exemplo: arara, ovo. */
            char continuar = 's';
            do
            {
                Console.WriteLine("Escreva uma palavra qualquer - iremos verificar se ela é um Palíndrome");
                string palavra = Console.ReadLine();  //receber palavra
                char[] word = palavra.ToCharArray(); // palavra convertida em array de chars
                char[] inverso = new char[word.Length];

                for (int i = 0; i<word.Length; i++) //percorrer charArray do final para o inicio, colocando as ultimas letras da array no inicio da string aux
                {
                    inverso[(inverso.Length - 1) - i] = word[i];
                }
                // só foi necessariio usar sequenceEqual porque comparei vetores. Poderia ter feito inverso como string usando o algoritmo do inverterpalavra

                if (inverso.SequenceEqual(word))   // função que compara sequencias de elementos de mesmo tipo, de outra forma poderia ter sido feito com outro loop
                {
                    Console.WriteLine("A palavra é um Palíndrome");
                }
                else
                {
                    Console.WriteLine("A palavra não é um Palíndrome");
                }

                Console.WriteLine("Deseja repetir? Aperte 's' caso sim, qualquer outra tecla caso não");
                continuar=char.Parse(Console.ReadLine());

            } while (continuar == 's');
        }
    }
}
