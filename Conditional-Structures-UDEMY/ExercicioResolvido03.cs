using System;

namespace EstruturaCondicional
{
    public static class Exercicio03
    {
        public static void Executar()
        {
            Console.WriteLine("Informe três números inteiros com espaço entre eles");

            string[] vet = Console.ReadLine().Split(' ');
            var x = int.Parse(vet[0]);
            var y = int.Parse(vet[1]);
            var z = int.Parse(vet[2]);

            if (x < y && x < z)
            {
                Console.WriteLine($"MENOR = {x}");
            }
            else if (y < z)
            {
                Console.WriteLine($"MENOR = {y}");
            }
            else 
            {
                Console.WriteLine($"MENOR = {z}");
            }
        }
    }
}