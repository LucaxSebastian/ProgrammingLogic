/*
    Escreva um programa que leia 2 valores X e Y e que imprima todos os valores entre eles cujo resto da divisão dele por 5 for igual a 2 ou igual a 3.
    
    ENTRADA: O arquivo de entrada contém 2 valores positivos inteiros quaisquer, não necessariamente em ordem crescente.

    SAÍDA: Imprima todos os valores conforme exemplo abaixo, sempre em ordem crescente.
*/

using System;

namespace URI_1133
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, menor, maior;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            menor = X;
            maior = Y;

            if (X > Y)
            {
                menor = Y;
                maior = X;
            }

            for (int i = menor + 1; i < maior; i++)
            {
                if (i % 5 == 2 || i % 5 == 3)
                {
                    Console.WriteLine(i);
                }
            }
        } 
    }
}
