/*
    Escreva um programa que leia um valor inteiro N (1 < N < 1000). Este N é a quantidade de linhas de saída que serão apresentadas na execução do programa.
    
    ENTRADA: O arquivo de entrada contém um número inteiro positivo N.

    SAÍDA: Imprima a saída conforme o exemplo fornecido.
*/

using System;

namespace URI_1143
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for(int i = 1; i <= N; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;

                Console.WriteLine(primeiro + " " + segundo + " " + terceiro);
            }
        }
    }
}
