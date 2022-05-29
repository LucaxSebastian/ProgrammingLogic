/*
    Escreva um algoritmo que leia 2 valores inteiros X e Y calcule a soma dos números que não são múltiplos de 13 entre X e Y, incluindo ambos.

    ENTRADA: O arquivo de entrada contém 2 valores inteiros quaisquer, não necessariamente em ordem crescente.

    SAÍDA: Imprima a soma de todos os valores não divisíveis por 13 entre os dois valores lidos na entrada, inclusive ambos se for o caso.
*/

using System;

namespace URI_1132
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, Y, soma;

            soma = 0;

            X = int.Parse(Console.ReadLine());
            Y = int.Parse(Console.ReadLine());

            int menor = X;
            int maior = Y;

            if(X > Y)
            {
                menor = Y;
                maior = X;
            }

            for (int i = menor; i <= maior; i++)
            {
                if (i % 13 != 0)
                {
                    soma += i;
                }
            }
            
            Console.WriteLine(soma);
        } 
    }
}


