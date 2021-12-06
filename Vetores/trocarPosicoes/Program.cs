using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trocarPosicoes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*a)	Classe: TrocarPosicoes
	        Declare um array de inteiros de 16 posições, preencha com números gerados aleatoriamente, troque os 8 primeiros valores pelos 8 últimos.
            Mostre o array original e o array final.*/

            Random gerador = new Random();

            Console.WriteLine("Qual o tamanho do vetor desejado?");
            int tam = int.Parse(Console.ReadLine());
            int[] nums = new int[tam];

            Console.WriteLine("Esse é o vetor com {0} elementos formado por numeros aleatórios no intervalo de 0 a 100", tam);
            for (int i=0; i<nums.Length; i++) //populando array com numeros aleatórios e exibindo valores da array original
            {
                nums[i] = gerador.Next(100);
                Console.Write(nums[i]+" ");
            }
            Console.WriteLine("");

            /*for (int y=0; y<nums.Length/2; y++) // invertendo segunda metade pela primeira com um algoritmo retardado
            {
                int buffer = nums[y];
                nums[y] = nums[((nums.Length - 1) / 2) +1+y];
                nums[((nums.Length - 1) / 2) + 1 + y] = buffer;
            }*/

            for (int y = 0; y < nums.Length / 2; y++) // invertendo segunda metade pela primeira com um algoritmo otimizado (para avançar para a posição correspondente da segunda metade da sequencia basta adicionarmos ao seu indice o valor dessa metade!! é como criar um novo começo para a sequencia pulando o numero de indices que colocamos
            {
                int buffer = nums[y];
                nums[y] = nums[y+(tam/2)];
                nums[y + (tam / 2)] = buffer;
            }

            Console.WriteLine("Esse é o vetor com as metades trocadas");
            for (int z=0; z<nums.Length;z++) // exibindo nova array com metades invertidas
            {
                Console.Write(nums[z] + " ");
            }

            Console.ReadKey();
        }
    }
}
