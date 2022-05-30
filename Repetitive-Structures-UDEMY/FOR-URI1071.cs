using System;

namespace EstruturaRepetitiva
{
    public static class URI1071
    {
        public static void Executar()
        {
            Console.WriteLine("Informe um valor para X e um valor para Y");
            int.TryParse(Console.ReadLine(), out int x);
            int.TryParse(Console.ReadLine(), out int y);

            int max, min;

            if(x < y)
            {
                min = x;
                max = y;
            }
            else
            {
                min = y;
                max = x;
            }

            var soma = 0;

            for(int i=min+1; i < max; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"Soma = {soma}");
        }
    }
}