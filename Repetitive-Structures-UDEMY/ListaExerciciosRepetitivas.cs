using System;

namespace EstruturaRepetitiva
{
    public static class ListaDeExerciciosCondicionais
    {
        public static void MenuDeExercicios()
        {
            Console.WriteLine("--- Exercicios sobre Estruturas Repetitivas --- \n");
            
            
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
                case 2:  break;
                case 3:  break;


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