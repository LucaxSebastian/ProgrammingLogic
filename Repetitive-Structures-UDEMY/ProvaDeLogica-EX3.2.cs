/*
    Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
    Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
    essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
*/
using System;

namespace EstruturaRepetitiva
{
    public static class Exercicio07
    {
        public static void Executar()
        {
            Console.Write("Quantidade de valores inteiros: ");
            int.TryParse(Console.ReadLine(), out int N);

            Console.WriteLine($"Informe {N} valores inteiros: ");

            int dentro = 0;
            int fora = 0;

            for(int i = 0; i < N; i++)
            {
                int.TryParse(Console.ReadLine(), out int X);

                if(X >= 10 && X <= 20)
                {
                    dentro += 1;
                }
                else
                {
                    fora += 1;
                }
            }

            Console.WriteLine($"{dentro} in");
            Console.WriteLine($"{fora} out");
            Console.ReadKey();
        }
    }
}