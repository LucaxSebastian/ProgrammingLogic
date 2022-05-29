/*
    Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o     ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
               
                       y
                    |
                Q1  |   Q2
                    |
              ------------- x
                    |
                Q3  |   Q4
                    |
                    
    Se o ponto estiver na origem, escreva a mensagem “Origem”.

    Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a situação.

    ENTRADA: A entrada contem as coordenadas de um ponto.

    SAÍDA: A saída deve apresentar o quadrante em que o ponto se encontra.    
*/

using System;
using System.Globalization;

namespace URI_1041
{
    class URI
    {
        static void Main(string[] args)
        {
            double x, y;
            
            string [] coordenadas = Console.ReadLine().Split(' ');
            x = double.Parse(coordenadas[0]);
            y = double.Parse(coordenadas[1]);

            if (x == 0 && y == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (x == 0)
            {
                Console.WriteLine("Eixo Y");
            }
            else if (y == 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (x > 0 && y > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q4");
            }
        }
    }
}
