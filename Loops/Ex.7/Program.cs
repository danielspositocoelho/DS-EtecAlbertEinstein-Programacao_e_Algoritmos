using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Chute certo - receba número de 1  10, gere randomicamente um numero. Se numero gerado igual numero digitado, some ponto usuario, senão some ponto pc. Exiba placar a cada jogada, 0 p/sair
            int numUsuario = -1, pontosUsuario = 0, pontosComputador = 0; ;
            
            do
            { 
                Console.WriteLine("Digite um número de 1 a 10" + Environment.NewLine + "Para sair digite 0");
                numUsuario = int.Parse(Console.ReadLine());

                Random numPC = new Random();
                int numComputador = numPC.Next(1,11);           // O LIMITE SUPERIOR É EXCLUDENTE E O INFERIOR É INCLUDENTE
                if(numComputador!=numUsuario & numUsuario !=0)
                {
                    pontosComputador++;
                    Console.WriteLine("Não foi dessa vez! :-(" + Environment.NewLine + "Você chutou errado. O número gerado foi {0}!", numComputador);
                    Console.WriteLine("Computador - {0} pts." + Environment.NewLine + "Jogador - {1} pts.", pontosComputador, pontosUsuario);
                }
                else if(numUsuario==numComputador & numUsuario != 0)
                {
                    pontosUsuario++;
                    Console.WriteLine("Parabéns!" + Environment.NewLine + "Você chutou certo. O número gerado foi {0}!", numComputador);
                    Console.WriteLine("Computador - {0} pts." + Environment.NewLine + "Jogador - {1} pts.", pontosComputador, pontosUsuario);
                }

            } while (numUsuario != 0);

        }
    }
}
