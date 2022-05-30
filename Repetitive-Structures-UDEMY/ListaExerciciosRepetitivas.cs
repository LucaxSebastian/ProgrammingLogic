using System;
namespace EstruturaRepetitiva
{
    public static class ListaDeExerciciosRepetitivas
    {
        public static void MenuDeExercicios()
        {
            Console.WriteLine("--- Exercicios sobre Estruturas Repetitivas --- \n");
            Console.WriteLine("1) Exercício 01 - URI 1113 (Estrutura While)");  
            Console.WriteLine("2) Estrutura Repetitiva FOR");       
            
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
                case 2: EstruturaFOR.Executar(); break;
                case 3: break;


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