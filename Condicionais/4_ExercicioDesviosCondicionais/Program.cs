using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ExercicioDesviosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolver um programa que receba valores numéricos entre 0 (zero) e 100 (cem), digitados pelo usuário. Se o valor estiver dentro da faixa,
             * deverá apresentar a mensagem "Valor Válido" e o valor digitado. Caso o valor esteja fora da faixa, apresentar a mensagem "Valor Inválido" e o valor digitado.  */
            Console.WriteLine("Digite um número: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            if (num1 <= 100)
            {
                Console.Write("Valor Válido " + num1);
            }
            else
            {
                Console.Write("Valor Inválido " + num1);
            }

            Console.ReadKey();
        }
    }
}
