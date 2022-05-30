using System;

namespace EstruturaRepetitiva
{
    public static class EstruturaFOR
    {
        public static void Executar()
        {
            Console.Write("Informe a quantidade de números que você deseja informar: ");
            int.TryParse(Console.ReadLine(), out int N);

            var soma = 0;

            for(int i = 0; i < N; i++)
            {
                int.TryParse(Console.ReadLine(), out int x);
                soma += x;
            }

            Console.WriteLine($"Valor da soma = {soma}");
            Console.ReadKey();
        }
    }
}