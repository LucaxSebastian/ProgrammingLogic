/*
    A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:

              SALÁRIO           |   % DE REAJUSTE   
            0 - 400.00                  15%     
            400.01 - 800.00     |       12%       
            800.01 - 1200.00    |       10%       
            1200.01 - 2000.00   |       7%   
            Acima de 2000.00    |       4%     
            
    Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
    
    ENTRADA: A entrada contém apenas um valor de ponto flutuante, com duas casas decimais.

    SAÍDA: Imprima 3 linhas na saída: o novo salário, o valor ganho de reajuste e o percentual de reajuste ganho, conforme exemplo abaixo.   
*/

using System;
using System.Globalization;

namespace URI_1048
{
    class URI
    {
        static void Main(string[] args)
        {
            double salario, percentual, novoSalario, reajuste;

            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salario <= 400.0)
            {
                percentual = 15.0;
            }
            else if ( salario <= 800.0)
            {
                percentual = 12.0;
            }
            else if (salario <= 1200.0)
            {
                percentual = 10.0;
            }
            else if (salario <= 2000.0)
            {
                percentual = 7.0;
            }
            else
            {
                percentual = 4.0;
            }

            reajuste = salario * percentual / 100.0;
            novoSalario = salario + reajuste;

            Console.WriteLine("Novo salario: " + novoSalario.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Em percentual: " + percentual + " %");
        }
    }
}
