using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_ExercicioDesviosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Junte os dois programas acima. Libere a entrada de maiores de 18 anos, meninas e amigos.*/

            Console.WriteLine("Qual a sua idade?");
            int idade = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Seu gênero é Feminino ou Masculino (F/M) ?");
            char gen = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Você é amigo(a) do dono?");
            Console.WriteLine("Escreva True para 'Sim' e False para 'Não'");
            bool amigo = Convert.ToBoolean(Console.ReadLine());

            if (idade >= 18 && (gen == 'F' || gen == 'f') && amigo==true)
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
