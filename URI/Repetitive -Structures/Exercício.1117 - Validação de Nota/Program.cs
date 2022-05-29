/*
    Faça um programa que leia as notas referentes às duas avaliações de um aluno. Calcule e imprima a média semestral. Faça com que o 
    algoritmo só aceite notas válidas (uma nota válida deve pertencer ao intervalo [0,10]). Cada nota deve ser validada separadamente.
    
    ENTRADA: A entrada contém vários valores reais, positivos ou negativos. O programa deve ser encerrado quando forem lidas duas notas válidas.

    SAÍDA: Se uma nota inválida  for lida, deve ser impressa a mensagem "nota invalida".
           Quando duas notas válidas forem lidas, deve ser impressa a mensagem "media = " seguido do valor do cálculo. O valor deve ser apresentado com duas casas                após o ponto decimal.
*/

using System;
using System.Globalization;

namespace URI_1117
{
    class URI
    {
        static void Main(string[] args)
        {
           double n1, n2, media;

           n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

           while (n1 < 0 || n1 > 10)
           {
               Console.WriteLine("nota invalida");
               n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
           }
          
          n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

          while (n2 < 0 || n2 > 10)
          {
              Console.WriteLine("nota invalida");
              n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
          }

            media = (n1 + n2) / 2.0;

            Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
