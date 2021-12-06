using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace p.a.aula15.ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Faça um Programa que leia números até que o usuário não queira mais digitar os números.
            //No final escrever a soma dos valores lidos.
            
            char continuar;
            double numFinal = 0;

            do
            {
                Console.WriteLine("Escreva um número qualquer");
                double num = double.Parse(Console.ReadLine());
          
                numFinal = numFinal + num;
                Console.WriteLine("Quer continuar? Digite 's' para Sim e 'n' para não");
                continuar = char.Parse(Console.ReadLine());

            } 
            while (continuar =='s' || continuar =='S');

            Console.WriteLine("Soma total dos números digitados {0}", numFinal); // outra forma de concatenação de strings

            Console.ReadKey();
        }
    }
}
