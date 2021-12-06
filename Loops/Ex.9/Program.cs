using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._9
{
    class Program
    {
        static void Main(string[] args)
        { /* Programa Progressão Aritmética - receba primeiro termo, razao e limite - exiba os tres valores acima dos termos da p.a. resultante deles
           Lembre-se - n(i) = n1 + (i-1)* Razão  onde i=posicao A=numero 
           */
            int continuar = -1;

            do
            {
                Console.WriteLine("PROGRESSÃO ARITMÉTICA" + Environment.NewLine + "Digite o primeiro termo (número inteiro)");
                int n1 = int.Parse(Console.ReadLine());  //primeiro termo

                Console.WriteLine("Digite a razão da p.a.");
                float r = float.Parse(Console.ReadLine());  //razão

                Console.WriteLine("Digite o limite da p.a. (número inteiro)");
                int lim = int.Parse(Console.ReadLine()); // limite

                int n; // número genérico da p.a.
                string pa = "P.A. - ";

                for (int i = 1; i <= lim; i++)
                {
                    n = (int)(n1 + ((i - 1) * r));
                    pa = pa + n.ToString() + " ";
                }

                Console.WriteLine("Primeiro Termo = {0}" + Environment.NewLine + "Razão = {1}" + Environment.NewLine + "Limite = {2}", n1, r, lim);
                Console.WriteLine(pa);

                Console.WriteLine(Environment.NewLine + "Deseja repetir? Digite 0 para sair e qualquer outro número para repetir");
                continuar=int.Parse(Console.ReadLine());
            } while (continuar != 0);

        }
    }
}
