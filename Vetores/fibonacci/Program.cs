using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            /*FIBONACCI --> n[0]=0, n[1]=1, n[i]=n(i-1) + n(i-2), sendo i>=2
             RECEBA O INDICE INTEIRO E EXIBA O VALOR DO NUMERO FIBONACCI CORRESPONDENTE.
            */
            char continuar='s';

                while(continuar=='s')
                {
                    Console.WriteLine("Informe o termo do fibonacci desejado");
                    int indice = int.Parse(Console.ReadLine());
                    double[] fibonacci = new double[indice];

                        for (int i = 0; i<indice; i++)
                        {   
                            if (i>=2)
                            {
                                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                                Console.Write(fibonacci[i] + ", ");
                            }
                            else
                            {
                                fibonacci[i] = i;
                                Console.Write(fibonacci[i]+ ", ");
                            }
                            
                        }

                    Console.WriteLine("Deseja continuar? Aperter 's' para sim e qualquer outra tecla para não");
                    continuar=char.Parse(Console.ReadLine());       
                }
        }

    }
}
