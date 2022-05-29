/*
    Leia um valor inteiro N. Este valor será a quantidade de valores que serão lidos em seguida. Para cada valor lido, mostre uma mensagem em inglês dizendo se este       valor lido é par (EVEN), ímpar (ODD), positivo (POSITIVE) ou negativo (NEGATIVE). No caso do valor ser igual a zero (0), embora a descrição correta seja (EVEN         NULL), pois por definição zero é par, seu programa deverá imprimir apenas NULL.
    
    ENTRADA: A primeira linha da entrada contém um valor inteiro N(N < 10000) que indica o número de casos de teste. Cada caso de teste a seguir é um valor inteiro X                (-107 < X <107).
    
    SAÍDA: Para cada caso, imprima uma mensagem correspondente, de acordo com o exemplo abaixo. Todas as letras deverão ser maiúsculas e sempre deverá haver um espaço            entre duas palavras impressas na mesma linha.
*/

using System;

namespace URI_1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, X;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                X = int.Parse(Console.ReadLine());

                if (X % 2 == 0 && X > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if (X % 2 != 0 && X > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if (X % 2 == 0 && X < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if (X % 2 != 0 && X < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else
                {
                    Console.WriteLine("NULL");
                }
            }
        } 
    }
}

