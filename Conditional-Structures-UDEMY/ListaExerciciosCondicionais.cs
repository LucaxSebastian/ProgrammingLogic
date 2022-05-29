using System;

namespace EstruturaCondicional
{
    public static class ListaDeExerciciosCondicionais
    {
        public static void MenuDeExercicios()
        {
            Console.WriteLine($"--- Exercicios sobre Estruturas Condicionais --- \n");

            Console.WriteLine("5) SAIR");

        }

        public static void ExecutarExercicio()
        {
            Console.Write("\nEscolha o número do exercício: ");
            int.TryParse(Console.ReadLine(), out int opcao);
            Console.WriteLine();

            switch(opcao)
            {
                case 1:  break;



                case 10: 
                    Console.WriteLine("Saindo... Obrigado!");
                    System.Environment.Exit(0);
                break;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente\n"); 
                    MenuDeExercicios();
                break;
            }
        }
    }
}