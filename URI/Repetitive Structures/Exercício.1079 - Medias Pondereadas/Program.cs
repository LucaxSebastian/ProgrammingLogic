/*
    Leia 1 valor inteiro N, que representa o número de casos de teste que vem a seguir. Cada caso de teste consiste de 3 valores reais, cada um deles com uma casa         decimal. Apresente a média ponderada para cada um destes conjuntos de 3 valores, sendo que o primeiro valor tem peso 2, o segundo valor tem peso 3 e o terceiro         valor tem peso 5.
    
    ENTRADA: O arquivo de entrada contém um valor inteiro N na primeira linha. Cada N linha a seguir contém um 
             caso de teste com três valores com uma casa decimal cada valor.
             
    SAÍDA: Para cada caso de teste, imprima a média ponderada dos 3 valores, conforme exemplo abaixo.
*/

using System;
using System.Globalization;

namespace URI_1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            double v1, v2, v3, media; // Media Ponderada

            for (int i = 0; i < N; i++)
            {
                string [] valores = Console.ReadLine().Split(' ');
                v1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
                v2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
                v3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
                
                media = (v1 * 2.0 + v2 * 3.0 + v3 * 5.0) / 10.0; // 10 = soma das notas peso

                Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
            }
        } 
    }
}

