using System;

namespace vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            //crie um programa que receba em uma array quatro numeros reais e devolva  media aritmetica deles
            int qntAvaliacoes = 4;

            float[] notas = new float[qntAvaliacoes];  // criando array 'notas' --> tipo[] nome_da_array = new tipo[qnt de elementos];
         
            for (int i=0; i<notas.Length; i++) //recebendo dados e populando array
            {
                Console.WriteLine("Escreva a nota nº {0}", i+1);
                notas[i] = float.Parse(Console.ReadLine());
            }

            float media = 0;

            for (int i=0; i<notas.Length; i++) // somando valores dos dados
            {
                media += notas[i];
            }

            media = media / notas.Length; // dividindo pelo total de dados

            Console.WriteLine("A média dos valores digitados é igual a {0}", media); //exibindo media resultante

        
        }
    }
}
