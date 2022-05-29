/*
    Leia um valor inteiro, que é o tempo de duração em segundos de um determinado evento em uma fábrica, e informe-o expresso no formato horas:minutos:segundos.

    ENTRADA: O arquivo de entrada contém um valor inteiro N.

    SAÍDA: Imprima o tempo lido no arquivo de entrada (segundos), convertido para horas:minutos:segundos, conforme exemplo fornecido.

*/

using System;
using System.Globalization;

namespace URI_1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, resto, horas, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            // 1 hora = 60 minutos = 3600 segundos

            horas = N / 3600;
            resto = N % 3600;

            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        
            Console.ReadLine();
        }
    }
}
