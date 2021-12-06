using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_ExercicioDesvioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*MeiaEntrada Desenvolva um programa que calcule meia entrada para menores de 12 anos, maiores de 65 anos ou estudantes. Receba os parâmetros do usuário. Idade (inteiro), estudante
           (lógico). Faça um único se para testar todas as condições de uma única vez. O valor da entrada é R$ 20,00. Exibir o valor da entrada a ser pago pelo cliente. */

            Console.WriteLine("Informe sua idade (Responda apenas em números) ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Você é estudante? (Responda apenas 'true' para 'Sim' ou 'false' para 'Não')");
            bool student = Convert.ToBoolean(Console.ReadLine());

            if(student==true || age<12 || age>65 )
            {
                Console.WriteLine("Você tem direito à meia-entrada - valor da entrada R$ 20,00 ");
            }
            else
            {
                Console.WriteLine("Você não tem direito à meia-entrada.");
            }

            Console.ReadKey();
        }
    }
}
