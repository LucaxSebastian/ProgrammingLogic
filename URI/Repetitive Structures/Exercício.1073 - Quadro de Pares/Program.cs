/*
    Leia um valor inteiro N. Apresente o quadrado de cada um dos valores pares, de 1 até N, inclusive N, se for o caso.
    
    ENTRADA: A entrada contém um valor inteiro N (5 < N < 2000).

    SAÍDA: Imprima o quadrado de cada um dos valores pares, de 1 até N, conforme o exemplo abaixo.

    Tome cuidado! Algumas linguagens tem por padrão apresentarem como saída 1e+006 ao invés de 1000000 o que 
    ocasionará resposta errada. Neste caso, configure a precisão adequadamente para que isso não ocorra.
*/

using System;

namespace URI_1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, quadrado;

            N = int.Parse(Console.ReadLine());

            for(int i = 2; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                   quadrado = i * i;
                   Console.WriteLine(i + "^2 = " + quadrado);
                }
            }
        } 
    }
}

