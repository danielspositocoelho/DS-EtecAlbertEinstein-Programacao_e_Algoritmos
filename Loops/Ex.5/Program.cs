using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int pcpoints = 0;
            int userpoints = 0;
            int resposta = 1;

            while (resposta != 0)
            {
                Random gerador = new Random();
                int num = gerador.Next(1, 100000);

                Console.WriteLine("O Número {0} é par ou impar?", num);                                      // use /n para quebrar linha invez de environment.newline  
                Console.WriteLine("Escolha: " + "\n 1 – Par" + " \n 2 – Impar" + "\n 0 - Sair");
                Console.WriteLine("Para sair digite 0");
                resposta = int.Parse(Console.ReadLine());

                if (resposta == 0)
                {
                    Console.WriteLine("Obrigado!");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    Console.WriteLine("Atenção - Digite 1 para PAR, 2 para IMPAR e 0 para SAIR - tente novamente.");
                }

                if (resposta == 1 && num % 2 == 0 || resposta == 2 && num % 2 != 0)
                {
                    userpoints++;
                    Console.WriteLine("Parabéns! O número sorteado - {0} - é par!", num);
                    Console.WriteLine("Computador - {0}pts", pcpoints);
                    Console.WriteLine("Jogador - {0}pts", userpoints);
                }
                else if (resposta == 1 && num % 2 != 0 || resposta == 2 && num % 2 == 0)
                {
                    pcpoints++;
                    Console.WriteLine("Computador - {0}pts", pcpoints);
                    Console.WriteLine("Jogador - {0}pts", userpoints);
                }
            }
        }
    }
}

