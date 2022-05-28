/*
    Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo 
    pode começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
    
    ENTRADA: A entrada contém dois valores inteiros representando a hora de início e a hora de fim do jogo.
    
    SAÍDA: Apresente a duração do jogo conforme exemplo abaixo.
*/

using System;

namespace URI_1046
{
    class URI
    {
        static void Main(string[] args)
        {
            int HrInicial, HrFinal, duracao; 

            string [] horas = Console.ReadLine().Split(' ');
            HrInicial = int.Parse(horas[0]);
            HrFinal = int.Parse(horas[1]);

            if (HrInicial < HrFinal)
            {
                duracao = HrFinal - HrInicial;
            }    
            else
            {
                duracao = 24 - HrInicial + HrFinal;
            }

            Console.WriteLine("O JOGO DUROU "  + duracao + " HORA(S)"); 
        }
    }
}
