/*
    Leia 100 valores inteiros. Apresente então o maior valor lido e a posição dentre os 100 valores lidos.

    ENTRADA: O arquivo de entrada contém 100 números inteiros, positivos e distintos.

    SAÍDA: Apresente o maior valor lido e a posição de entrada, conforme exemplo abaixo.
*/

using System;
using System.Globalization;

namespace URI_1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, posicao, maior;

            maior = 0;
            posicao = 1;

            for (int i = 1; i <= 100; i++)
            {
                N = int.Parse(Console.ReadLine());

                if (N > maior)
                {
                   maior = N;
                   posicao = i;
                }
            }

            Console.WriteLine(maior);
            Console.WriteLine(posicao);
        } 
    }
}
