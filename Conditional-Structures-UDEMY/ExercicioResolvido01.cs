using System;
using System.Globalization;

namespace EstruturaCondicional
{
    public static class Exercicio01
    {
        public static void Executar()
        {
            Console.Write("Digite a primeira nota: ");
            var nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            Console.Write("Digite a segunda nota: ");
            var nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            var soma = nota1 + nota2;

            Console.WriteLine("NOTA FINAL: {0}", soma.ToString("F1", CultureInfo.InvariantCulture));

            if (soma > 60.0)
            {
                Console.WriteLine("APROVADO");
            }
            else 
            {
                Console.WriteLine("REPROVADO");
            }
        }
    }
}