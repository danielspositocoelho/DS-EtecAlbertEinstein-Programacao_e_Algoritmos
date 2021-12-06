using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ExercicioDesvioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*13) Calculadora

Desenvolva um programa que receba 2 números digitados pelo usuário, e armazene em duas variáveis do tipo real. Após receber os 2 números,
 apresente o seguinte menu:  1 – adição / 2 – subtração / 3 – multiplicação / 4 – divisão / 5 – resto da divisão

Depois que o usuário escolher a opção, efetue a operação escolhida pelo usuário, sempre o primeiro pelo segundo, por exemplo:
            Se o usuário digitar 10 e 5 e escolher subtração, subtraia 10 – 5. Exiba ao final o cálculo, da seguinte forma:

            10 – 5 = 5
            Utilize o comando caso (switch/case   //break//default):escolha operacao
            caso 1
            caso 2
            ...
            outrocaso
            escreval ("Opção Inválida")  fimescolha */

            Console.WriteLine("CALCULADORA");
            Console.WriteLine("Informe o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Informe o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Menu de operações: 1 – adição / 2 – subtração / 3 – multiplicação / 4 – divisão / 5 – resto da divisão");
            int operacao = Convert.ToInt16(Console.ReadLine());

            switch (operacao)
            {
                case 1:
                    double soma = num1 + num2;
                    Console.WriteLine(num1 + " + " + num2 + " = " + soma);
                    break;

                case 2:
                    double sub = num1 + num2;
                    Console.WriteLine(num1 + " - " + num2 + " = " + sub);
                    break;

                case 3:
                    double mult = num1 * num2;
                    Console.WriteLine(num1 + " x " + num2 + " = " + mult);
                    break;

                case 4:
                    if (num2==0)
                    {
                        Console.WriteLine("O segundo número deve ser diferente de 0 - Reinicie o programa");
                    }
                    else
                    {
                        double div = num1 / num2;
                        Console.WriteLine(num1 + " / " + num2 + " = " + div);
                    }
                    break;

                case 5:
                    double mod = num1 % num2;
                    Console.WriteLine(num1 + " módulo " + num2 + " = " + mod);
                    break;

                default:
                    Console.WriteLine("Opção Inválida");
                    break;
            }
            Console.ReadKey();
        }
    }
}
