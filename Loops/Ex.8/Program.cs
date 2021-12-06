using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Numero Invertido - receba um numero entre 100 e 999 e mostre o numero digitado acima do numero invertido (ex: digitado 198, invertido 891). Não transforme o numero em string 
             * Caso o usuario digite 0 o programa encerra
             */

            int num=-1;
            do
            {
                Console.WriteLine("Digite um número entre 100 e 999. Iremos invertê-lo." + Environment.NewLine + "Digite 0 para sair");
                num = int.Parse(Console.ReadLine());
                if (num >= 100 & num<=999 &num !=0)
                {
                    int algaInicio, algaMeio, algaFim;
                    algaInicio = num / 100;
                    algaMeio = (num / 10) % 10;
                    algaFim = num % 10;

                    int numInvert = algaFim*100 + algaMeio*10 + algaInicio;
                    Console.WriteLine("Número Digitado: {0}" + Environment.NewLine + "Inverso do número: {1}", num, numInvert);
                }
                else if ((num<100 || num>999) & (num !=0))
                {
                    Console.WriteLine("Atenção - O número deve estar entre 100 e 999." + Environment.NewLine + "Digite 0 para sair e qualque outro numero para continuar");
                    num = int.Parse(Console.ReadLine());
                }
            } while (num!=0);

        }
    }
}
