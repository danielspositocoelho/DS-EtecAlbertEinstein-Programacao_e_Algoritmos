using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_ExercicioDesvioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Utilize o conceito de propriedade distributiva para ordenar os valores. Não use variável auxiliar desta vez. Utilize ifs independentes. Baseie-se no algoritmo fornecido */
            Console.WriteLine("Informe o primeiro número: ");
            int numA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            int numB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe o terceiro número: ");
            int numC = Convert.ToInt32(Console.ReadLine());

            if (numA>numB)
            {
                numB = numA - numB;
                numA = numA - numB;
                numB = numA + numB;
            }

            if (numA > numC)
            {
                numC = numA - numC;
                numA = numA - numC;
                numC = numA + numC;

            }
            if (numB > numC)
            {
                numC = numB - numC;
                numB = numB - numC;
                numC = numB + numC;

            }
            Console.WriteLine(numA + ", " + numB + ", "+numC);
            Console.ReadKey();
        
        }
    }
}
