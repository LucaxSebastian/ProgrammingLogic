/*
    Faça um programa que leia o nome de um vendedor, o seu salário fixo e o total de vendas efetuadas por ele no mês (em dinheiro). Sabendo que 
    este vendedor ganha 15% de comissão sobre suas vendas efetuadas, informar o total a receber no final do mês, com duas casas decimais.

    ENTRADA: O arquivo de entrada contém um texto (primeiro nome do vendedor) e 2 valores de dupla precisão (double) com duas casas decimais, 
             representando o salário fixo do vendedor e montante total das vendas efetuadas por este vendedor, respectivamente.

    SAÍDA: Imprima o total que o funcionário deverá receber, conforme exemplo fornecido.
*/

using System;
using System.Globalization;

namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeVendedor;
            double salarioFixo, TotalVendas, TotalSalario;

            Console.Write("Digite o nome do vendedor: ");
            nomeVendedor = Console.ReadLine();
            salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            TotalVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            TotalSalario = TotalVendas * 15 / 100 + salarioFixo;

            Console.WriteLine("TOTAL = R$ " + TotalSalario.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
