using System;

namespace LogicaProgramacao.EstruturaSequencial
{
    public static class Exercicio1
    {
        public static void Executar()
        {
            Console.Write("Digite uma frase: ");
            string frase = Console.ReadLine();

            Console.Write("Informe uma cor: ");
            string x = Console.ReadLine();

            Console.Write("Informe a segunda cor: ");
            string y = Console.ReadLine();

            Console.Write("Informe a terceira cor: ");
            string z = Console.ReadLine();


            Console.Write("Informe 3 palavras: ");
            string[] vet = Console.ReadLine().Split(' ');
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];

            Console.WriteLine("\nVoce digitou: \n");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.ReadKey();
        }
    }
}