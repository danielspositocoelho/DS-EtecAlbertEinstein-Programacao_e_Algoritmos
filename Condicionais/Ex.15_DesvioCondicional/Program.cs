using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._15_DesvioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Digite o número a ser invertido (o número deve estar entre 100 e 999)");
			int num = Convert.ToInt16(Console.ReadLine());

			int algaInicio, algaMeio, algaFim;
			algaInicio = num / 100;
			algaMeio = (num / 10) % 10;
			algaFim = num % 10;

			Console.WriteLine("O número invertido é: " + algaFim + algaMeio + algaInicio);
			Console.ReadKey();
		}
    }
}
