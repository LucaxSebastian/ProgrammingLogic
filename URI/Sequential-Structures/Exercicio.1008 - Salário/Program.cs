/*
    Escreva um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por hora
    e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas decimais.
    
  ENTRADA: O arquivo de entrada contém 2 números inteiros e 1 número com duas casas decimais, representando o número, quantidade 
           de horas trabalhadas e o valor que o funcionário recebe por hora trabalhada, respectivamente.

  SAÍDA: Imprima o número e o salário do funcionário, conforme exemplo fornecido, com um espaço em branco antes e depois da igualdade. 
         No caso do salário, também deve haver um espaço em branco após o $.
*/

using System;
using System.Globalization;

namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int NumFuncionario, QtdHorasTrab;
            double ValorHoraTrab, salario;

            NumFuncionario = int.Parse(Console.ReadLine());
            QtdHorasTrab = int.Parse(Console.ReadLine());
            ValorHoraTrab = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = ValorHoraTrab * QtdHorasTrab;

            Console.WriteLine("NUMBER = " + NumFuncionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
