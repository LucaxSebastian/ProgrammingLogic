/*
    Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A seguir, 
    calcule e mostre o valor da conta a pagar.
    
      CÓDIGO    |   ESPECIFICAÇÃO     |   PREÇO     
        1           Cachorro quente       R$ 4,00
        2       |   X-Salada          |   R$ 4,50
        3       |   X-Bacon           |   R$ 5,00
        4       |   Torrada Simples   |   R$ 2,00
        5       |   Refrigerante      |   R$ 1,50
        
        ENTRADA: O arquivo de entrada contém dois valores inteiros correspondentes ao código e à quantidade de um item conforme tabela acima.
        
        SAÍDA: O arquivo de saída deve conter a mensagem "Total: R$ " seguido pelo valor a ser pago, com 2 casas após o ponto decimal.
*/


using System;
using System.Globalization;

namespace URI_1038
{
    class URI
    {
        static void Main(string[] args)
        {
            int codigo, quantidade;
            double precoTotal;

            string [] valores = Console.ReadLine().Split(' ');
            codigo = int.Parse(valores[0]);
            quantidade = int.Parse(valores[1]);

            switch(codigo)
            {
                case 1:
                    precoTotal = quantidade * 4.0;
                break;

                case 2:
                    precoTotal = quantidade * 4.5;
                break;

                case 3:
                    precoTotal = quantidade * 5.0;
                break;

                case 4:
                    precoTotal = quantidade * 2.0;
                break;

                default:
                    precoTotal = quantidade * 1.5;
                break;
            }

            Console.WriteLine("Total: R$ " + precoTotal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
