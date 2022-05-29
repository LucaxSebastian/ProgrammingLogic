using System;
using System.Globalization;

namespace LogicaProgramacao.EstruturaSequencial
{
    public static class FuncoesMatematicas
    {
        public static void Executar()
        {
            double x = 3.0;
            double y = 4.0;
            double z = -5.0;
            double A, B, C;

            A = Math.Sqrt(x);
            B = Math.Sqrt(y);
            C = Math.Sqrt(25.0);
            Console.WriteLine($"Raiz quadrada de {x} = {A}");
            Console.WriteLine($"Raiz quadrada de {y} = {B}");
            Console.WriteLine($"Raiz quadrada de 25 = {C}");

            A = Math.Pow(x, y);
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 3.0);
            Console.WriteLine($"{x} elevado a {y} = {A}");
            Console.WriteLine($"{x} elevado a 3 = {B}");
            Console.WriteLine($"5 elevado a 3 = {C}");

            A = Math.Abs(y);
            B = Math.Abs(z);
            Console.WriteLine($"Valor absoluto de {y} = {A}");
            Console.WriteLine($"Valor absoulto de {z} = {B}");

            double a = 1;
            double b = 4;
            double c = 2;

            Console.WriteLine();

            var delta = Math.Pow(b, 2.0) - 4 * a * c;
            Console.WriteLine("delta = {0}", delta.ToString("F1", CultureInfo.InvariantCulture));

            var x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine("x1 = {0}", x1.ToString("F1", CultureInfo.InvariantCulture));
            Console.WriteLine("x2 = {0}", x2.ToString("F1", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    } 
}