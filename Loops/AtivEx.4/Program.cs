
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivEx._4
{
    class Program
    {
        static void Main(string[] args)
        {

            int tentativas = 0;
            int acertos = 0;
            int resposta = 1;

            while (resposta!=0)
            {
                Random gerador = new Random();
                int n1 = gerador.Next(1, 10);
                int n2 = gerador.Next(1, 10);
                int soma = n1 + n2;
                
                Console.WriteLine("Qual o resultado da soma de {0} + {1}?", n1, n2);
                Console.WriteLine("Para sair digite 0");
                resposta = int.Parse(Console.ReadLine());
                
                tentativas++;
                if(resposta==soma)
                {
                    acertos++;
                    Console.WriteLine("Parabéns! Você Acertou!");
                    Console.WriteLine("{0} + {1} = {2}", n1, n2, soma);
                    Console.WriteLine(acertos + " " + tentativas);
                    float porcent = (acertos*100)/tentativas;
                    Console.WriteLine("Percentual de acertos: " + porcent + "%");
                }
                else
                {
                    Console.WriteLine("Tente Novamente");
                    float porcent = (acertos * 100) / tentativas;
                    Console.WriteLine("Percentual de acertos: " + porcent + "%");
                }
            }
        }
    }
}
