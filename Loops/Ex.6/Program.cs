using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Faça um programa que exiba um número de 1 a 100 obtido randomicamente para o usuário e pergunte se ele quer apostar. Se sim, gere outro número obtido randomicamente. 
             * Se o número recebido pelo usuário for maior, pontue o usuário, se o número apresentado para o computador for maior, pontue o computador, se os números forem iguais, não pontue ninguém.
             * Exiba o placar a cada jogada. Utilize a o loop 
             * do while 
                      * do{
                            //código que será repetido enquanto a condição for verdadeira;
                            } while (condição booleana);
                            //Caixa de mensagem com opção de sim e não:
                            JOptionPane.showConfirmDialog(null, “Seu número é ” + n + “ Apostar?”,”Confirmação”, 0);*/
            bool continuar = true;
            int pontoUsuario = 0;
            int pontoComputador = 0;
            int jogada = 0;
            do {
                
                jogada++;
                Random gerador = new Random();
                int numUsuario = gerador.Next(1, 101);

                Console.WriteLine("Seu número é {0}. Apostar?", numUsuario);
                Console.WriteLine("Sim(s)  ou  Não(n)?");
                string resposta = Console.ReadLine();

                    if(resposta=="n")
                    {
                        continuar = false;
                    }
                
                int numComputador = gerador.Next(1,100);
                    if(numComputador>numUsuario)
                    {
                        Console.WriteLine("Não foi dessa vez! :-(" + Environment.NewLine + "o número gerado foi {0}", numComputador);
                        pontoComputador++;
                    }
                    else 
                    {
                        Console.WriteLine("Parabéns" + Environment.NewLine + "o número gerado foi {0}", numComputador);
                        pontoUsuario++;
                    }

                Console.WriteLine("Jogadas - {0}", jogada);
                Console.WriteLine("Computador - {0}", pontoComputador);
                Console.WriteLine("Jogador - {0}", pontoUsuario);
            } while (continuar==true);


        }
    }
}
