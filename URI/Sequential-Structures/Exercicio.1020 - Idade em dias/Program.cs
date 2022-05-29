/*
    Leia um valor inteiro correspondente à idade de uma pessoa em dias e informe-a em anos, meses e dias

    Obs.: apenas para facilitar o cálculo, considere todo ano com 365 dias e todo mês com 30 dias. Nos casos de teste nunca haverá uma situação 
          que permite 12 meses e alguns dias, como 360, 363 ou 364. Este é apenas um exercício com objetivo de testar raciocínio matemático simples.
          
    ENTRADA: O arquivo de entrada contém um valor inteiro.

    SAÍDA: Imprima a saída conforme exemplo fornecido.
*/

using System;

namespace URI_1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade, anos, meses, dias, resto; // informar a idade em dias em anos, meses e dias.

            idade = int.Parse(Console.ReadLine());

            anos = idade / 365;
            resto = idade % 365;

            meses = resto / 30;
            dias = resto % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
            
        }
    }
}
