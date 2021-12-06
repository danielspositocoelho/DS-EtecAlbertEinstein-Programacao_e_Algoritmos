using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14exDesvioCondicional
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Programa PAR IDEAL - Responda as seguintes questões sobre seu par ideal");

			Console.WriteLine("Qual faixa salarial lhe agradaria mais?");
			Console.WriteLine("Opções por quantidade de Salários Mínimos:  1 - dois salários, 2 - quatro salários, 3 - seis salários,  4 - oito salários,  5 - dez salários, 0 - nenhum");
			int salario = Convert.ToInt16(Console.ReadLine());

			int pontos = 0;
			pontos += salario;

			Console.WriteLine("Qual escolaridade lhe agrada mais?");
			Console.WriteLine("Opções (Digite apenas o número): 1-Não alfabetizado, 2-Fundamental, 3-Médio, 4-Superior, 5-Mestrado, 6-Doutorado, 0 - nenhum");
			int escolaridade = Convert.ToInt16(Console.ReadLine());

			pontos += escolaridade;

			Console.WriteLine("Qual estação do ano lhe agrada mais?");
			Console.WriteLine("Opções (Digite apenas o número): 1-primavera, 2-verão, 3-outono, 4-inverno, 0 - nenhum");
			int estacao = Convert.ToInt16(Console.ReadLine());

			pontos += estacao;

			Console.WriteLine("Qual passeio lhe agrada mais?");
			Console.WriteLine("Opções (Digite apenas o número): 1-cidade, 2-campo, 3-praia, 4-radical, 5-cruzeiro, 0 - nenhum");
			int viagem = Convert.ToInt16(Console.ReadLine());

			pontos += viagem;

			Console.WriteLine("Qual cor lhe agrada mais?");
			Console.WriteLine("Opções (Digite apenas o número): 1-preto, 2-azul, 3-verde, 4-vermelho, 5-branco, 0 - nenhum");
			int cor = Convert.ToInt16(Console.ReadLine());

			pontos += cor;

			Console.WriteLine("Qual gênero lhe atrai ?");
			Console.WriteLine("Opções: Digite 'm' para Masculino e 'f' para Feminino");
			char genero = Convert.ToChar(Console.ReadLine());


			if (genero == 'f')
			{
				switch (pontos)
				{
					case 5:

						Console.WriteLine("Helena");
						break;
					case 6:

						Console.WriteLine("Alice");
						break;
					case 7:

						Console.WriteLine("Laura");
						break;
					case 8:

						Console.WriteLine("Manuela");
						break;
					case 9:

						Console.WriteLine("Valentina");
						break;
					case 10:

						Console.WriteLine("Sophia");
						break;
					case 11:

						Console.WriteLine("Isabella");
						break;
					case 12:

						Console.WriteLine("Heloísa");
						break;
					case 13:

						Console.WriteLine("Luiza");
						break;

					case 14:

						Console.WriteLine("Júlia");
						break;
					case 15:

						Console.WriteLine("Lorena");
						break;
					case 16:

						Console.WriteLine("Lívia");
						break;
					case 17:

						Console.WriteLine("Maria Luiza");
						break;
					case 18:

						Console.WriteLine("Cecília");
						break;
					case 19:

						Console.WriteLine("Eloá");
						break;
					case 20:

						Console.WriteLine("Giovanna");
						break;
					case 21:

						Console.WriteLine("Maria Clara");
						break;
					case 22:

						Console.WriteLine("Maria Eduarda");
						break;

					case 23:

						Console.WriteLine("Giovanna");
						break;
					case 24:

						Console.WriteLine("Mariana");
						break;
					case 25:

						Console.WriteLine("Lara");
						break;

					default:

						Console.WriteLine("Se nenhum dos nomes lhe agrada, escolha um gênero diferente");
						break;
				}
			}

			if (genero == 'm')
			{

				switch (pontos)
				{
					case 5:

						Console.WriteLine("Diogo");
						break;
					case 6:

						Console.WriteLine("Juan");
						break;
					case 7:

						Console.WriteLine("Luiz Otávio");
						break;
					case 8:

						Console.WriteLine("Ian");
						break;
					case 9:

						Console.WriteLine("Antonio");
						break;
					case 10:

						Console.WriteLine("Igor");
						break;
					case 11:

						Console.WriteLine("Rodrigo");
						break;
					case 12:

						Console.WriteLine("Francisco");
						break;
					case 13:

						Console.WriteLine("Tomás");
						break;

					case 14:

						Console.WriteLine("André");
						break;
					case 15:

						Console.WriteLine("Joaquim");
						break;
					case 16:

						Console.WriteLine("Fernando");
						break;
					case 17:

						Console.WriteLine("Enzo Gabriel");
						break;
					case 18:

						Console.WriteLine("Erick");
						break;
					case 19:

						Console.WriteLine("Benjamin");
						break;
					case 20:

						Console.WriteLine("Yuri");
						break;
					case 21:

						Console.WriteLine("Vitor Hugo");
						break;
					case 22:

						Console.WriteLine("Ryan");
						break;

					case 23:

						Console.WriteLine("Emanuel");
						break;
					case 24:

						Console.WriteLine("Breno");
						break;
					case 25:

						Console.WriteLine("Luiz Felipe");
						break;

					default:

						Console.WriteLine("Se nenhum dos nomes lhe agrada, escolha um gênero diferente");
						break;
				}

			}
			Console.ReadKey();
		}
	}
}




