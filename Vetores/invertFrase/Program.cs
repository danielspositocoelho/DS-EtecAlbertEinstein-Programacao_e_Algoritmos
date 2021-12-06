using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace invertFrase
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que receba uma frase digitada pelo usuário e exiba a mesma frase com cada palavra invertida. Exemplo: ETEC Albert Einstein – CETE treblA nietsniE */
            
            string fraseInvertida="";                                                           //variavel para guardar a frase invertida
            Console.WriteLine("Digite uma frase - iremos inverter todas as palavras nela");
            string frase = Console.ReadLine();
            char[] fraseArray = frase.ToCharArray();                                            //convert frase original p charArray

            for(int i=0; i<fraseArray.Length; i++)                          // loop crescente pelos chars da frase até encontrar um elemento que marque fim de palavra (' ' || . || , ||último elemento da array) 
            {
                if(fraseArray[i]==32 || i==(fraseArray.Length-1) || fraseArray[i] == 44 || fraseArray[i] == 46)   //32 == ascii para ' '   &&   \0 == final da array  &&  44==ascii para ','  && 46==ascii para '.'
                {
                    if (i == (fraseArray.Length - 1))     // caso estivermos no último elemento, loop decrescente pelos chars incrementando o char atual na frase invertida, começando-a então pelos últimos chars da palavra até os primeiros 
                    {
                        for (int z = i; z >= 0; z--)    // caso o elemento atual seja o primeiro elemento, voltamos ao loop pai, em busca da proxima palavra
                        {
                            if (fraseArray[z] == 32 || fraseArray[i] == 44 || fraseArray[i] == 46)   // caso o elemento atual seja um marcador de fim de palavra, indicando que terminamos a palavra atual, voltamos ao loop pai
                            {
                                break;
                            }
                            fraseInvertida += fraseArray[z];
                        }
                    }
                    else
                    {       
                        for (int z = i - 1; z >= 0; z--)    // caso não estivermos no ultimo elemento, pulamos o atual, que é marcador de fim de palavra, para começar pela ultima letra da palavra atual e incrementala como primeira na frase invertida
                        {
                            if (fraseArray[z] == 32)
                            {
                                break;
                            }
                            fraseInvertida += fraseArray[z];
                        }
                        fraseInvertida += " ";      // adicionamos na frase invertida o espaço que pulamos ao inverter a palvra atual, para manter a ordem das palavras e espaços na fraseaer
                    }
                }
            }
            Console.WriteLine("Aqui está: {0}", fraseInvertida);
            Console.ReadKey();

            //poderia ter sido feito de um modo muito mais facil usando .split(' ') para separar a string original antes de cada espaço e criando um vetor de strints para armazenar, depois inverter cada uma com o algo invert palavra
        }
    }
}
