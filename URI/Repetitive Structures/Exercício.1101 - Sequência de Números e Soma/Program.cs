/*
    Leia um conjunto não determinado de pares de valores M e N (parar quando algum dos valores for menor ou igual a zero). Para cada 
    par lido, mostre a sequência do menor até o maior e a soma dos inteiros consecutivos entre eles (incluindo o N e M).
    
    ENTRADA: O arquivo de entrada contém um número não determinado de valores M e N. A última linha de entrada vai conter um número nulo ou negativo.

    SAÍDA: Para cada dupla de valores, imprima a sequência do menor até o maior e a soma deles, conforme exemplo abaixo.
*/

using System;

namespace URI_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int M, N;

            string[] valores = Console.ReadLine().Split(' ');
            M = int.Parse(valores[0]);
            N = int.Parse(valores[1]);

            while (M > 0 && N > 0)
            {
                int menor = M;
                int maior = N;

                if (M > N)
                {
                    menor = N;
                    maior = M;
                }

                int soma = 0;

                for (int i = menor; i <= maior; i++)
                {
                    soma += i;
                    Console.Write(i + " ");
                }

                Console.WriteLine("Sum=" + soma);
        
                valores = Console.ReadLine().Split(' ');
                M = int.Parse(valores[0]);
                N = int.Parse(valores[1]);
            }
        }
    }
}
