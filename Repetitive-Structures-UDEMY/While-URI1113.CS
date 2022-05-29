using System;

namespace EstruturaRepetitiva
{
    public static class Exercicio01
    {
        public static void Executar()
        {
            int x, y;

            Console.WriteLine("Informe um valor para X e Y");
            string[] vet = Console.ReadLine().Split(' ');
            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            while(x != y)
            {
                if(x < y)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }

                vet = Console.ReadLine().Split(' ');
                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);
            }

            Console.ReadKey();
        }
    }
}