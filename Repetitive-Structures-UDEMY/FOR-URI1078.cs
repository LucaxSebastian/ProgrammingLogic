using System;

namespace EstruturaRepetitiva
{
    public static class URI1078
    {
        public static void Executar()
        {
            Console.Write("Informe um número do qual você deseja ver a tabuada: ");
            var N = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i <= 10; i++)
            {
                var resultado = N * i;
                Console.WriteLine($"{N} X {i} = {resultado}");
            }

            Console.ReadKey();
        }
    }
}