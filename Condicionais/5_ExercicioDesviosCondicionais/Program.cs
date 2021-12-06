using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_ExercicioDesviosCondicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Desenvolva um programa que leia 4 notas escolares de um aluno e calcule a média aritmética das notas. 
            Caso a média seja maior ou igual a 5, exibir a mensagem "Aluno aprovado". Se o aluno ficou entre 3 e 5, exibir a mensagem “Recuperação”, 
            se não atingiu a média mínima (menos do que 3), exibir a mensagem "Aluno reprovado".
            Apresente junto à mensagem a média do aluno.*/

            Console.WriteLine("Informe a primeira nota: ");
            int num1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe a segunda nota: ");
            int num2 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe a terceira nota: ");
            int num3 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Informe a quarta nota: ");
            int num4 = Convert.ToInt16(Console.ReadLine());

            float media = (num1 + num2 + num3 + num4) / 4;

            if (media>=5)
                {
                    Console.WriteLine("Média " + media);
                    Console.WriteLine("Aprovado(a)");
                }
            else if (media>=3 && media<5)
                {
                    Console.WriteLine("Média " + media);
                    Console.WriteLine("RECUPERAÇÃO");
                }
            else
                {
                    Console.WriteLine("Média " + media);
                    Console.WriteLine("Aluno(a) Reprovado(a)");
                }
            Console.ReadKey();
        }
    }
}
