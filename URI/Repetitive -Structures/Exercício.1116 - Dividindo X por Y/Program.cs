/*
    Escreva um algoritmo que leia 2 números e imprima o resultado da divisão do primeiro pelo segundo. 
    Caso não for possível mostre a mensagem “divisao impossivel” para os valores em questão.

    ENTRADA: A entrada contém um número inteiro N. Este N será a quantidade de pares de valores inteiros (X e Y) que serão lidos em seguida.

    SAÍDA: Para cada caso mostre o resultado da divisão com um dígito após o ponto decimal, ou “divisao impossivel” caso não seja possível efetuar o cálculo.

    Obs.: Cuide que a divisão entre dois inteiros em algumas linguagens como o C e C++ gera outro inteiro. Utilize cast :)
*/

using System;
using System.Globalization;

namespace URI_1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            double x, y, divisao;

            N = int.Parse(Console.ReadLine());

            for(int i = 0; i < N; i++)
            {
                string [] valores = Console.ReadLine().Split(' ');
                x = double.Parse(valores[0]);
                y = double.Parse(valores[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    divisao = x / y;
                    Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        } 
    }
}

