using System;
using System.Globalization;

namespace EstruturaCondicional
{
    public static class Exercicio02
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o valor de A, B e C com espaços entre os valores");

            string[] vet = Console.ReadLine().Split(' ');
            var A = double.Parse(vet[0], CultureInfo.InvariantCulture);
            var B = double.Parse(vet[1], CultureInfo.InvariantCulture);
            var C = double.Parse(vet[2], CultureInfo.InvariantCulture);

            var DELTA = Math.Pow(B, 2.0) - 4 * A * C;
            Console.WriteLine($"DELTA = {DELTA}");

            if (A == 0 || DELTA < 0.0)
            {
                Console.WriteLine("Impossível Calcular");
            }
            else
            {
                var R1 = (-B + Math.Sqrt(DELTA)) / (2.0 * A);
                var R2 = (-B - Math.Sqrt(DELTA)) / (2.0 * A);

                Console.WriteLine("R1 = {0}", R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = {0}", R2.ToString("F5", CultureInfo.InvariantCulture)); 
            }

            Console.ReadKey();
        }
    }   
}