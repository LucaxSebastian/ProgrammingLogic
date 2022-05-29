using System;

namespace EstruturaCondicional
{
    public static class ListaDeExerciciosCondicionais
    {
        public static void MenuDeExercicios()
        {
            Console.WriteLine("--- Exercicios sobre Estruturas Condicionais --- \n");
            Console.WriteLine("1) Exercício Resolvido 01");
            Console.WriteLine("2) Exercícico 02 - URI 1036");
            Console.WriteLine("3) Exercício Resolvido 03");
            Console.WriteLine("5) SAIR");
        }

        public static void ExecutarExercicio()
        {
            Console.Write("\nEscolha o número do exercício: ");
            int.TryParse(Console.ReadLine(), out int opcao);
            Console.WriteLine();

            switch(opcao)
            {
                case 1: Exercicio01.Executar(); break;
                case 2: Exercicio02.Executar(); break;
                case 3: Exercicio03.Executar(); break;

                case 5: 
                    Console.WriteLine("Saindo... Obrigado!");
                    System.Environment.Exit(0);
                break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente\n"); 
                    MenuDeExercicios();
                    ExecutarExercicio();
                break;
            }
        }
    }
}