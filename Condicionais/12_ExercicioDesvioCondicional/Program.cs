using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_ExercicioDesvioCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Pesquisa
            Desenvolva um programa que teste responda se a pessoa está apta para participar da pesquisa.
            Uma empresa quer testar a satisfação dos clientes com um produto lançado recentemente no mercado. 
            Os consumidores entrevistados deverão ser do sexo masculino, idade entre 20 e 25 anos, da classe A ou B, nível superior, que tenham adquirido o produto há mais de 6 meses e menos de 1 ano.
            Teste as informações e exiba “Apto” ou “Fora da faixa pesquisada”.
            Crie Se’s encadeados e passe para a próxima pergunta somente se ele continuar apto.*/

            string sex;
            int age;
            bool classe;
            bool superior;
            float tempoCompra;

            Console.WriteLine("Informe seu sexo");
            sex = Console.ReadLine();

            if (sex == "masculino" || sex == "M" || sex == "m" || sex == "homem")
            {
                Console.WriteLine("Informe sua idade");
                age = Convert.ToInt16(Console.ReadLine());

                if (age >= 20 && age <= 25)
                {
                    Console.WriteLine("Informe se você se encontra na classe social A ou B (digite 'true' para Sim e 'false' para não)");
                    classe = Convert.ToBoolean(Console.ReadLine());

                    if (classe == true)
                    {
                        Console.WriteLine("Informe se você possui ensino superior ou não (digite 'true' para Sim e 'false' para não)");
                        superior = Convert.ToBoolean(Console.ReadLine());

                        if (superior == true)
                        {
                            Console.WriteLine("Informe a quantos meses você adquiriu o produto (digitando apenas números)");
                            tempoCompra = Convert.ToSingle(Console.ReadLine());

                            if(tempoCompra>6 && tempoCompra<12)
                            {
                                Console.WriteLine("APTO para a pesquisa");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Você está fora da faixa pesquisada");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Você está fora da faixa pesquisada");
                    }
                }
                else
                {
                    Console.WriteLine("Você está fora da faixa pesquisada");
                }
            }
            else
            {
                Console.WriteLine("Você está fora da faixa pesquisada");
            }
            Console.ReadKey();
        }
    }
}
