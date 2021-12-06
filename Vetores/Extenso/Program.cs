using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Extenso
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Extenso - Crie um array de palavras e preencha - o com as palavras necessárias para que, dado um número recebido do usuário, escreva - o por extenso.*/
            string[] numeros= new string[]{
            "e", "um", "dois", "três", "quatro", "cinco", "seis", "sete", "oito", "nove", "dez","onze","doze","treze","catorze","quinze","dezesseis","dezessete","dezoito","dezenove",
            "vinte","trinta","quarenta","cinquenta","sessenta","setenta","oitenta","noventa","cem","duzentos","trezentos","quatrocentos","quinhentos","seiscentos","setecentos","oitocentos",
            "novecentos","mil"};
            
            Console.WriteLine("Qual número você deseja ver escrito por extenso? (Limite 999.999");
            string num = Console.ReadLine();
            char[] algarismos = num.ToCharArray();
            string numExtenso = "";

            for (int i=0; i<algarismos.Length; i++)
            {

            }
        }
    }
}
