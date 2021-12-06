using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_ExercicioDesvioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que verifique a idade e libere a entrada da pessoa.
            * Solicite que o usuário digite a idade e armazene em uma variável do tipo inteiro, chamada idade.*/

            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());

            /* Crie outra variável do tipo logico chamada amigo e solicite ao usuário que diga se é amigo do dono*/

            Console.WriteLine("Você é amigo do dono?");
            Console.WriteLine("Escreva True para 'Sim' e False para 'Não'");
            bool amigo = Convert.ToBoolean(Console.ReadLine());

            /* Se a idade for maior ou igual a 18 ou a pessoa for amiga do dono, exibir a mensagem “Pode entrar”, 
             * caso contrário, exibir “Não autorizado”. . */
            if (idade >= 18 || amigo == true)
            {
                Console.Write("Pode Entrar");
            }
            else
            {
                Console.Write("Não Autorizado");
            }

            Console.ReadKey();
        }
    }
}
