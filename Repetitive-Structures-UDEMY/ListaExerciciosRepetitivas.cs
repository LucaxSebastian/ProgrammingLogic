using System;
namespace EstruturaRepetitiva
{
    public static class ListaDeExerciciosRepetitivas
    {
        public static void MenuDeExercicios()
        {
            Console.WriteLine("--- Exercicios sobre Estruturas Repetitivas ---");
            Console.WriteLine("1) Exercício 01 - URI 1113 (Estrutura While)");  
            Console.WriteLine("2) Exercício 02 - Estrutura Repetitiva FOR");  
            Console.WriteLine("3) Exercício 03 - URI 1078 (Estrutura FOR)");  
            Console.WriteLine("4) Exercício 04 - URI 1071 (Estrutura FOR)");
            Console.WriteLine("5) Exercício 05 - Estrutura Repetitiva Do While");   
            Console.WriteLine("6) SAIR");
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
                case 3: URI1078.Executar(); break;
                case 4: URI1071.Executar(); break;
                case 5: DoWhile.Executar(); break;

                case 6: 
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