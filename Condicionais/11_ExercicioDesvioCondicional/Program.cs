using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_ExercicioDesvioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Aumento - Programa deverá ter o seguinte output: Salário anterior = <salario>; Aumento = <valor do aumento>; Salário atual = <salário atual>;

            Uma empresa decidiu dar reajuste a seus funcionários de acordo com os seguintes critérios:

            o 10% para os funcionários que recebam um salario inferior a 1000 reais (<1000)

            o 8% para os funcionários que recebam até 2000 reais (<=2000)

            o 6% para os funcionários que recebam até 3500 reais (<=3500)

            o 4% para os funcionários que recebam até 5000 reais (<=5000)

            o 2% para os demais.*/


            double salarioAtual;
            double aumento;

            Console.WriteLine("A empresa está dando um aumento percentual do salario a depender da sua faixa salarial");
            Console.WriteLine("Para saber seu novo salario e o valor do aumento informe seu salário atual usando apenas números");
            double salario = Convert.ToDouble(Console.ReadLine());

            if(salario < 1000)
            {
               double percent = 0.1;
               aumento = salario * percent;
               salarioAtual = salario + aumento; // OU salarioAtual = salario * (1+percent);

                Console.WriteLine("SALARIO ANTERIOR: " + salario);
                Console.WriteLine("VALOR DO AUMENTO PERCENTUAL: " + aumento);
                Console.WriteLine("SALARIO ATUAL: " + salarioAtual);
            }
                else if (salario <= 2000)
                {
                    double percent = 0.08;
                    aumento = salario * percent; 
                    salarioAtual = salario + aumento;

                    Console.WriteLine("SALARIO ANTERIOR: " + salario);
                    Console.WriteLine("VALOR DO AUMENTO PERCENTUAL: " + aumento);
                    Console.WriteLine("SALARIO ATUAL: " + salarioAtual);
                }
                    else if (salario <= 3500)
                    {
                        double percent = 0.06;
                        aumento = salario * percent;
                        salarioAtual = salario + aumento;
                
                        Console.WriteLine("SALARIO ANTERIOR: " + salario);
                        Console.WriteLine("VALOR DO AUMENTO PERCENTUAL: " + aumento);
                        Console.WriteLine("SALARIO ATUAL: " + salarioAtual);

                    }
                        else if (salario <= 5000)
                        {
                            double percent = 0.04;
                            aumento = salario * percent;
                            salarioAtual = salario + aumento; 

                            Console.WriteLine("SALARIO ANTERIOR: " + salario);
                            Console.WriteLine("VALOR DO AUMENTO PERCENTUAL: " + aumento);
                            Console.WriteLine("SALARIO ATUAL: " + salarioAtual);
                        }
                            else
                            {
                                double percent = 0.02;
                                aumento = salario * percent;
                                salarioAtual = salario + aumento;

                                Console.WriteLine("SALARIO ANTERIOR: " + salario);
                                Console.WriteLine("VALOR DO AUMENTO PERCENTUAL: " + aumento);
                                Console.WriteLine("SALARIO ATUAL: " + salarioAtual);
                            }
           
            Console.ReadKey();
        }
    }
}
