/*
    Neste problema, deve-se ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o código de uma peça 2, 
    o número de peças 2 e o valor unitário de cada peça 2. Após, calcule e mostre o valor a ser pago.

    ENTRADA: O arquivo de entrada contém duas linhas de dados. Em cada linha haverá 3 valores, respectivamente dois inteiros e um valor com 2 casas decimais.

    SAÍDA: A saída deverá ser uma mensagem conforme o exemplo fornecido abaixo, lembrando de deixar um espaço após 
           os dois pontos e um espaço após o "R$". O valor deverá ser apresentado com 2 casas após o ponto.  
*/

using System;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int CodP1, QtdP1, CodP2, QtdP2; // P = ' Pessa '
            double ValorP1, ValorP2, total;

            string[] valores = Console.ReadLine().Split(' '); // 1° linha com 3 valores
            CodP1 = int.Parse(valores[0]);
            QtdP1 = int.Parse(valores[1]);
            ValorP1 = double.Parse(valores[2], CultureInfo.InvariantCulture); // depois dessa linha de comando pulará para linha de baixo

            valores = Console.ReadLine().Split(' '); // 2° linha com 2 valores
            CodP2 = int.Parse(valores[0]);
            QtdP2 = int.Parse(valores[1]);
            ValorP2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total  = ValorP1 * QtdP1 + ValorP2 * QtdP2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
