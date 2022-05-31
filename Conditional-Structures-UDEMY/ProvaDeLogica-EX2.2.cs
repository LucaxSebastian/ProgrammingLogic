/*
    Ler os valores dos três coeficientes "a", "b" e "c" de uma equação do segundo grau (ax² + bx + c = 0)
    Em seguida, mostrar os valores das raízes da equação, conforme exemplos, usando a fórmula de Baskara (veja
    abaixo). Se a equação não possuir raízes (o valor de "a" não pode ser zero, e o valor de "delta" não pode ser
    negativo), mostrar uma mensagem "Impossivel calcular".

    Fórmula = X = -b +- √Δ / 2a onde: Δ = b² - 4ac
*/

using System;
using System.Globalization;

namespace EstruturaCondicional
{
    public static class Exercicio04
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o valor de a, b e c: ");
            string[] valores = Console.ReadLine().Split(' ');
            var a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            var b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            var c = double.Parse(valores[2], CultureInfo.InvariantCulture);
            Console.WriteLine();

            var delta = Math.Pow(b, 2) - 4 * a * c;

            Console.WriteLine("Δ = {0}", delta.ToString("F1", CultureInfo.InvariantCulture));

            if(a == 0.0 || delta < 0.0)
            {
                Console.WriteLine("Impossível calcular");
            } 
            else
            {
                var x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
                var x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

                Console.WriteLine("X1 = {0}", x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("X2 = {0}", x2.ToString("F5", CultureInfo.InvariantCulture));
            }

            Console.ReadKey();
        }
    }
}