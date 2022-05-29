/*
    Faça um programa que calcule e mostre o volume de uma esfera sendo fornecido o valor de seu raio (R). 
    A fórmula para calcular o volume é: (4/3) * pi * R3. Considere (atribua) para pi o valor 3.14159.

    Dica: Ao utilizar a fórmula, procure usar (4/3.0) ou (4.0/3), pois algumas linguagens (dentre elas o C++), 
    assumem que o resultado da divisão entre dois inteiros é outro inteiro.
    
    ENTRADA: O arquivo de entrada contém um valor de ponto flutuante (dupla precisão), correspondente ao raio da esfera.

    SAÍDA: A saída deverá ser uma mensagem "VOLUME" conforme o exemplo fornecido abaixo, com um espaço antes 
           e um espaço depois da igualdade. O valor deverá ser apresentado com 3 casas após o ponto.
*/

using System;
using System.Globalization;

namespace URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double Vf, R, pi; // Vf = Volume Esfera -- R = raio

            pi = 3.14159;

            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Vf = (4.0/3.0) * pi * R * R * R;  // usar '4.0' ou '3.0', pois o C# assume que o resultado da
                                             // divisao entre dois numeros inteiros e outro numero inteiro
            Console.WriteLine("VOLUME = " + Vf.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}
