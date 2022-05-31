/*
    Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
    casas decimais conforme exemplos.
    Fórmula:  Area = PI.Raio²

    Considere o valor de π = 3.14159
*/

using System;
using System.Globalization;

namespace EstruturaSequencial
{
    public static class Exercicio5
    {
        public static void Executar()
        {
            Console.Write("Informe o valor do raio do círculo: ");
            var raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine();

            var pi = 3.14159;

            var area = pi * Math.Pow(raio, 2);

            Console.WriteLine("Área = {0}", area.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}