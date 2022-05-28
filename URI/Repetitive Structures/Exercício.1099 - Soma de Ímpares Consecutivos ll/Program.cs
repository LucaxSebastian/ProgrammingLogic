/*
    Leia um valor inteiro N que é a quantidade de casos de teste que vem a seguir. Cada caso de teste consiste de dois inteiros X e Y. 
    Você deve apresentar a soma de todos os ímpares existentes entre X e Y.
    
    ENTRADA: A primeira linha de entrada é um inteiro N que é a quantidade de casos de teste que vem a seguir. 
             Cada caso de teste consiste em uma linha contendo dois inteiros X e Y.
             
    SAÍDA: Imprima a soma de todos valores ímpares entre X e Y.
*/

using System;

namespace URI_1099
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int X = int.Parse(valores[0]);
                int Y = int.Parse(valores[1]);

                int menor, maior;

                if (X < Y)
                {
                    menor = X;
                    maior = Y;
                }
                else
                {
                    menor = Y;
                    maior = X;
                }

                int soma = 0;

                for (int j = menor + 1; j < maior; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma += j;
                    }
                }

                Console.WriteLine(soma);
            }
        }
    }
}
