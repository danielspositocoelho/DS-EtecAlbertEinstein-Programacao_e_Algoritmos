using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_v2_estudoSortAlgorithm
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

            if (numA > numB)
            {
                numB = numA - numB;
                Console.WriteLine(" 1 dentro primeiro if  " + numA + ", " + numB + ", " + numC);
                numA = numA - numB;
                Console.WriteLine(" 2 dentro primeiro if  " + numA + ", " + numB + ", " + numC);
                numB = numA + numB;
                Console.WriteLine(" final dentro primeiro if  " + numA + ", " + numB + ", " + numC);
            }


            Console.WriteLine("entre primeiro e segundo if  " + numA + ", " + numB + ", " + numC);

            if (numA > numC)
            {
                numC = numA - numC;
                numA = numA - numC;
                numC = numA + numC;

                Console.WriteLine("dentro do segundo if  " + numA + ", " + numB + ", " + numC);
            }


            Console.WriteLine("entre segundo e terceiro if  " + numA + ", " + numB + ", " + numC);

            if (numB > numC)
            {
                numC = numB - numC;
                numB = numB - numC;
                numC = numB + numC;

                Console.WriteLine("dentro do terceiro if  " + numA + ", " + numB + ", " + numC);
            }

            Console.WriteLine("final" + numA + ", " + numB + ", " + numC);
            Console.ReadKey();

        }
    }
}
