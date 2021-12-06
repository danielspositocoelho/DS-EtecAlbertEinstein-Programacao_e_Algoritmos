using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuadas
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, resultado, limite;

            Console.WriteLine("Escreva qual tabuada você deseja consultar, informando apenas o seu número");
            n1=int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva até onde você quer ir com a tabuada, o limite máximo");
            limite = int.Parse(Console.ReadLine());

            for (int i=0; i<=limite; i++)
            {
                resultado = n1 * i;
                Console.WriteLine(n1+" X "+ i + " = " + resultado);
            }
            Console.ReadKey();
        }
    }
}
