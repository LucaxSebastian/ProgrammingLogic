/*  Leia 4 valores inteiros A, B, C e D. A seguir, se B for maior do que C e se D for maior do que A, e a soma de C com D for maior que a
    a soma de A e B e se C e D, ambos, forem positivos e se a variável A for par escrever a mensagem "Valores aceitos", senão escrever
    "Valores nao aceitos".     
    
    ENTRADA: Quatro números inteiros A, B, C e D.
    
    SAÍDA: Mostre a respectiva mensagem após a validação dos valores.
*/

using System;

namespace URI_1035
{
    class URI
    {
        static void Main(string[] args)
        {
            int A, B, C, D, soma1, soma2;

            string [] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);
            C = int.Parse(valores[2]);
            D = int.Parse(valores[3]);

            soma1 = C + D;
            soma2 = A + B;
        
            if (B > C && D > A && soma1 > soma2 && C > 0 && D > 0 && A % 2 == 0)
            {
                Console.WriteLine("Valores aceitos");
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }    
        }
    }
}
