using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace encontrarPares
{
    class Program
    {
        static void Main(string[] args)
        {
            //	Declare um array de inteiros de 40 posições, preencha com números aleatórios. Contar e exibir quantos valores pares ele possui e exibir o array gerado.

            int[] nums = new int[40];
            Random gerador = new Random();
            int pares = 0;


            Console.WriteLine("Aqui está o array gerado: ");
            for (int i=0; i<nums.Length;i++)
            {
                nums[i] = gerador.Next(100);
                if (nums[i]%2==0)
                {
                    pares++;
                }
                Console.Write(nums[i] + " ");
            }
            Console.WriteLine("\r\nExistem {0} números pares nesta array", pares);
            Console.ReadKey();
        }
    }
}
