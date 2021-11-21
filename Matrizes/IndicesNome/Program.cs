using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndicesNome
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Leia uma matriz de tamanho 3 x ? contendo as letras do Alfabeto Maiúsculas na linha 0 seguida das letras minúsculas na linha 1 e os números de 0 a 9. 
             * Faça um programa que mostre os índices da Matriz que formam seu nome e o seu RG.
char[][] matriz = {
{'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T', 'U','V','W','X','Y','Z'},
{'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w', 'x','y','z'},
{'0','1','2','3','4','5','6','7','8','9','-','.',' '}
};
// Inicializar o array com os caracteres que formam seus nomes e números
// Por exemplo, Cris seria formado pelos seguintes caracteres:
char[][] dados = new char[2][];
char[] nome = "Cristiane Tuji".toCharArray();
char[] RG = "12.345.678-9".toCharArray();
dados[0] = nome;
dados[1] = RG;
String[] indices = {"Índices do nome: ","Índices do RG: "};
// Criar o código que percorra o array contendo seus dados e busque os índices de cada item na matriz. Para percorrer uma matriz são necessários dois for. 
Para percorrer duas matrizes são necessários 4 for.*/

            char[][] matriz = {
                               new char[] {'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T', 'U','V','W','X','Y','Z'},
                               new char[] {'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w', 'x','y','z'},
                               new char[] {'0','1','2','3','4','5','6','7','8','9','-','.',' ','x'}
                              };

            char[][] dados = new char[2][];
            char[] nome = "Daniel Spósito".ToCharArray();
            char[] RG = "34.347.251-x".ToCharArray();
            dados[0] = nome;
            dados[1] = RG;

            for (int i=0; i<dados.Length;i++)
            {
                for (int y = 0; y< dados[i].Length; y++)
                {
                    for (int z = 0; z < matriz.Length; z++)
                    {
                        for (int w = 0; w < matriz[z].Length; w++)
                        {
                            if (dados[i][y]==matriz[z][w])
                            {
                                Console.WriteLine(dados[i][y]+" está na coordenada " + z +" "+ w +" da array ");
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
