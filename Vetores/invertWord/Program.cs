using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertWord
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que receba uma palavra e exiba a palavra digitada e a mesma palavra invertida. Exemplo: Cristiane - enaitsirC 
Converta a palavra recebida em um array de caracteres  - ToCharArray() -  e percorra este array de trás para frente, pegando as letras e concatenando em uma variável String.
*/
            Console.WriteLine("Escreva uma palavra qualquer - iremos inverter suas letras");
            string palavra = Console.ReadLine();  //receber palavra
            string invertWord = "";
            char[] word = palavra.ToCharArray(); // palavra convertida em array de chars

            for (int i=word.Length-1; i>=0;i--) //percorrer charArray do final para o inicio, colocando as ultimas letras da array no inicio da string aux
            {
                invertWord += word[i]; 
            }

            Console.WriteLine("Palavra Original: {0}\r\nPalavra invertida: {1}", palavra, invertWord); // exibir palavra original e palavra invertida
            Console.ReadKey();

        }
    }
}
