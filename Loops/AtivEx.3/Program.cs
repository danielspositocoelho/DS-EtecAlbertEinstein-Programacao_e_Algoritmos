using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivEx._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa lhe da o fatorial de um número inteiro, digite o número:");
            int num = int.Parse(Console.ReadLine());

            for (int i=1, fat=1; i<=num; i++)
            {
                fat = fat*i;
                if (i == 1)
                {
                    Console.Write("{0}! {1}", num, i);
                }
                else
                {
                    Console.Write("*{0}", i);
                }

                if (i == num)
                {
                    Console.Write("={0}", fat);
                }
            }
            Console.ReadKey();
        }
    }
}
