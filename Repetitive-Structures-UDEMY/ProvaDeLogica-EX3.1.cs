/*
    Escreva um programa que repita a leitura de uma senha até que ela seja válida. Para cada leitura de senha
    incorreta informada, escrever a mensagem "Senha Invalida". Quando a senha for informada corretamente deve ser
    impressa a mensagem "Acesso Permitido" e o algoritmo encerrado. Considere que a senha correta é o valor 2002.
*/
using System;

namespace EstruturaRepetitiva
{
    public static class Exercicio06
    {
        public static void Executar()
        {
            Console.WriteLine("Informe a senha correta com 4 digitos numéricos: ");
            int.TryParse(Console.ReadLine(), out int senha);

            while(senha != 2002)
            {
                Console.WriteLine("Senha Invalida");

                senha = int.Parse(Console.ReadLine());   
            }

            Console.WriteLine("Acesso permitido");
        }
    }
}