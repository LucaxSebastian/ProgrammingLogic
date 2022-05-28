/*  Leia 3 valores de ponto flutuante e efetue o cálculo das raízes da equação de Bhaskara. Se não for possível calcular as raízes, mostre a
    mensagem correspondente “Impossivel calcular”, caso haja uma divisão por 0 ou raiz de numero negativo.
    
    ENTRADA: Leia três valores de ponto flutuante (double) A, B e C.
    
    SAÍDA: Se não houver possibilidade de calcular as raízes, apresente a mensagem "Impossivel calcular". Caso contrário, imprima o resultado
           das raízes com 5 dígitos após o ponto, com uma mensagem correspondente conforme exemplo abaixo. Imprima sempre o final de linha após cada mensagem.    
*/

using System;
using System.Globalization;

namespace URI_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, delta, R1, R2;
             
            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(B, 2) - 4*A*C;

            if (A == 0 || delta < 0)
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                R1 = (-B + Math.Sqrt(delta)) / (2 * A);
                R2 = (-B - Math.Sqrt(delta)) / (2 * A);

                Console.WriteLine("R1 = " + R1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + R2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
