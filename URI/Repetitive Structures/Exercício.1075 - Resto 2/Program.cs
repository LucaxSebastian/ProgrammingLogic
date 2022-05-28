/*
    Leia um valor inteiro N. Apresente todos os números entre 1 e 10000 que divididos por N dão resto igual a 2.

    ENTRADA: A entrada contém um valor inteiro N (N < 10000).

    SAÍDA: Imprima todos valores que quando divididos por N dão resto = 2, um por linha.
*/


using System;

namespace URI_1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, divisiveis;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < 10000; i++)
            {
                divisiveis = i / N;

                if  (i % N == 2)
                {
                    Console.WriteLine(i);   
                }
            }
        } 
    }
}

