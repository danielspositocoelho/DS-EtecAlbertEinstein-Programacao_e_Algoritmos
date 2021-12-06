using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivEx._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Este programa lhe dá a soma de todos os números de 1 até o número inteiro digitado: digite o número");
            int num = int.Parse(Console.ReadLine());

            for (int i=1, tot=0; i<=num; i++)
            {

                //4! 1+2+3+4=10   0+1+2=3
                tot = tot + i;
                if(i==1)
                {
                    Console.Write("{0}! {1}", num, i);
                }
                else
                {
                    Console.Write("+{0}", i);
                }

                if(i==num)
                {
                    Console.Write("={0}", tot);
                }
            }

            Console.ReadKey();
        }
    }
}
