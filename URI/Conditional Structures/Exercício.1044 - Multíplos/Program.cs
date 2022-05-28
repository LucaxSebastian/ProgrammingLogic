/*
    Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao Multiplos", 
    indicando se os valores lidos são múltiplos entre si.
    
    ENTRADA: A entrada contém valores inteiros.
    
    SAÍDA: A saída deve conter uma das mensagens conforme descrito acima.
*/

using System;

namespace URI_1044
{
    class URI
    {
        static void Main(string[] args)
        {
            int A, B;

            string [] valores = Console.ReadLine().Split(' ');
            A = int.Parse(valores[0]);
            B = int.Parse(valores[1]);

            if (A % B == 0 || B % A == 0)
            {
                Console.WriteLine("Sao multiplos");        
            }
            else
            {
                Console.WriteLine("Nao sao multiplos");
            }
        }
    }
}
