using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indices_do_nome
{
    class Program
    {
        static void Main(string[] args)
        {

            /*            Leia um array de 52 posições contendo as letras do Alfabeto Maiúsculas seguida das letras minúsculas.
             *            Faça um programa que mostre a sequência numérica dos índices do array que forme seu nome. Armazene os índices em um array de inteiros chamado índices.
             *            O array de índices precisa ter o mesmo tamanho do nome.Exiba seu nome e abaixo os índices do array.Converta seu nome para um array de caracteres:
            //            char[] letras = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                          'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' }
                          char[] nome = “Cristiane”.ToCharArray();
                          int[] índices = nome.Lengt
            */
            char[] letras = new char[]{
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
                          'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
            };
            
            Console.WriteLine("Digite seu primeiro nome");
            string name = Console.ReadLine();
            
            char[] nome = name.ToCharArray();
           // int[] indices = new int[nome.Length];

           
            for(int i=0; i<nome.Length; i++)                        // começando pela array menor e entrando na maior com um break quando encontrar o char - performance
            {
                for (int z = 0; z < letras.Length; z++)
                {
                    if (nome[i] == letras[z])
                    {
                        Console.WriteLine("Letra " + nome[i] + " está no indice " + z);
                        break;
                    }
                }
            }
            
            
           /* Console.WriteLine("A sequência numérica correspondente aos indices da array que forma seu nome é");
            for (int i =0; i<indices.Length; i++)
            {
                Console.Write(indices[i] + ", ");
            }*/

            Console.ReadKey();
        }
    }
}
