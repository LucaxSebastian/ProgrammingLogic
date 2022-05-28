/*
    Faça um algoritmo para ler um número indeterminado de dados, contendo cada um, a idade de um indivíduo. O último dado, 
    que não entrará nos cálculos, contém o valor de idade negativa. Calcular e imprimir a idade média deste grupo de indivíduos.
    
    ENTRADA: A entrada contém um número indeterminado de inteiros. A entrada será encerrada quando um valor negativo for lido.

    SAÍDA: A saída contém um valor correspondente à média de idade dos indivíduos.

           A média deve ser impressa com dois dígitos após o ponto decimal.
*/

using System;
using System.Globalization;

namespace URI_1154
{
    class URI
    {
        static void Main(string[] args)
        {
            int idade, soma = 0, cont = 0;
            double media;
          
            idade = int.Parse(Console.ReadLine());

            while (idade >= 0)
            {
                soma += idade;
                cont += 1;

                idade = int.Parse(Console.ReadLine());
            }

            media = (double) soma / cont;

            Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
