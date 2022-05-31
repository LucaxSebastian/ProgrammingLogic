/*
    Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
    código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
*/

using System;
using System.Globalization;
namespace EstruturaSequencial
{
    public static class Exercicio4
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o código da peça 1, n° de peças 1, valor unitário de c/ peça 1");
            string[] vet = Console.ReadLine().Split(' ');
            var codigoPeca1 = int.Parse(vet[0]);
            var numeroDePecas1 = int.Parse(vet[1]);
            var valorUnitarioPeca1 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine("Informe o código da peça 2, n° de peças 2, valor unitário de c/ peça 2");
            vet = Console.ReadLine().Split(' ');
            var codigoPeca2 = int.Parse(vet[0]);
            var numeroDePecas2 = int.Parse(vet[1]);
            var valorUnitarioPeca2 = double.Parse(vet[2], CultureInfo.InvariantCulture);
            Console.WriteLine();

            var totalPagar = (numeroDePecas1 * valorUnitarioPeca1) + (numeroDePecas2 * valorUnitarioPeca2);

            Console.WriteLine("VALOR A PAGAR: {0}", totalPagar.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}