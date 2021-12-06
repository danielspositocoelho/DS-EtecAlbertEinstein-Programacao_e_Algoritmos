using System;

namespace AtivEx._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número inteiro, apresentaremos sua tabuada até 10");
            int num = int.Parse(Console.ReadLine());
            
            for(int i=0; i<=10;i++)
            {
                int prod = num * i;
                Console.WriteLine("{0} X {1} = {2}", i, num, prod);
            }

            Console.ReadKey();
        }
    }
}
