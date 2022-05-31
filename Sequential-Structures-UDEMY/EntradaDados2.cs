using System;
using System.Globalization;
namespace EstruturaSequencial
{
    public static class Exercicio2
    {
        public static void Executar()
        {
            Console.Write("Informe um numero inteiro: ");
            int.TryParse(Console.ReadLine(), out int valor_inteiro);

            Console.Write("Informe um caractere: ");
            char.TryParse(Console.ReadLine(), out char caractere);

            Console.Write("Informe um numero do tipo double: ");
            double valor_double = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Informe um nome, sexo, idade e altura: ");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);

            Console.WriteLine();

            Console.WriteLine("--- Dados Informados --- ");
            Console.WriteLine($"Nome: {nome}");
            Console.WriteLine($"Sexo: {sexo}");
            Console.WriteLine($"Idade: {idade}");
            Console.WriteLine("Altura: {0}", altura.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}