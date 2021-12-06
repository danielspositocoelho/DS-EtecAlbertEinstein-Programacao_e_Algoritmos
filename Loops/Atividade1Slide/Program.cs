using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade1Slide
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, pares = 0, impares = 0; ;
            Random gerador = new Random(); // Classe que gera número aleatórios

            for (int i=1; i<=100; i++)
            {
                Console.WriteLine("Serão gerados 100 números aleatórios e o programa irá contar quantos são pares e quantos ímpares");
                numero = gerador.Next(1, 101); // sintaxe da classe Random usando método next, que por default retorna int
                Console.WriteLine(numero);

                if (numero%2==0)
                {
                    pares++;
                }
                else
                {
                    impares++;
                }
            }
            Console.WriteLine("Dos números gerados " + pares + " são pares" + " e " + impares + " são impares");
            Console.ReadKey();
        }
    }
}
