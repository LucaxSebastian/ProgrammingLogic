using System;

namespace LogicaProgramacao.EstruturaSequencial
{
    public static class ListaDeExerciciosEstruturasSequenciais
    {
        public static void MenuDeExercicios()
        {
            Console.WriteLine("--- Exercicios sobre Estruturas Sequenciais --- \n");
            Console.WriteLine("1) Entrada de dados - PARTE 1");
            Console.WriteLine("2) Estrada de dados - PARTE 2");
            Console.WriteLine("3) Funções Matemáticas");

            Console.WriteLine("5) SAIR");

        }

        public static void ExecutarExercicio()
        {
            Console.Write("\nEscolha o número do exercício: ");
            int.TryParse(Console.ReadLine(), out int opcao);
            Console.WriteLine();

            switch(opcao)
            {
                case 1: Exercicio1.Executar(); break;

                case 2: Exercicio2.Executar(); break;

                case 3: FuncoesMatematicas.Executar(); break;

                case 4:                 break;



                case 10: 
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