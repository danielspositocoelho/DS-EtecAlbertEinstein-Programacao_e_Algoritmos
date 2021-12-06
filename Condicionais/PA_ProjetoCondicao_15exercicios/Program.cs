using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PA_ProjetoCondicao_15exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Crie um programa que verifique a idade e libere a entrada da pessoa.
             * Solicite que o usuário digite a idade e armazene em uma variável do tipo inteiro, chamada idade.*/

            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());

            /* Crie outra variável do tipo caracter chamada genero e solicite o gênero ao usuário.*/

            Console.WriteLine("Seu gênero é Feminino ou Masculino (F/M) ?");
            char gen = Convert.ToChar(Console.ReadLine());

            /* Se a idade for >=18 ou o gênero for ‘F’, exibir a mensagem “Pode entrar”, caso contrário, exibir “Não autorizado”. */
            if ((idade>=18) && (gen=='F' || gen=='f'))
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
