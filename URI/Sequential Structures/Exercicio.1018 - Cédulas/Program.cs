/*
    Leia um valor inteiro. A seguir, calcule o menor número de notas possíveis (cédulas) no qual o valor pode ser decomposto. 
    As notas consideradas são de 100, 50, 20, 10, 5, 2 e 1. A seguir mostre o valor lido e a relação de notas necessárias.
    
    ENTRADA: O arquivo de entrada contém um valor inteiro N (0 < N < 1000000).

    SAÍDA: Imprima o valor lido e, em seguida, a quantidade mínima de notas de cada tipo necessárias, conforme o exemplo fornecido. 
           Não esqueça de imprimir o fim de linha após cada linha, caso contrário seu programa apresentará a mensagem: “Presentation Error”.
*/

using System;

namespace URI_1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int X, resto, quociente, nota; // quociente = resultado da divisao

            X = int.Parse(Console.ReadLine());

            resto = X;         

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota; // agora o resto da divisao de (resto / nota) foi atribuido a variavel "resto"

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");
        }
    }
}
