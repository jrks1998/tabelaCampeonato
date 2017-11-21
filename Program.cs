using System;

namespace tabelaCampeonato
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo a;
            Tabela t = new Tabela();

            do {
                System.Console.WriteLine("Menu:");
                System.Console.WriteLine("1 - Informe novo time e sua pontuação \n2 - Finaliza e exibe a tabela");
                System.Console.WriteLine("Informe sua opção:");
                a = Console.ReadKey();
                if (a.Key == ConsoleKey.D1) {
                    System.Console.WriteLine("Digite o nome do time:");
                    string time = Console.ReadLine();
                    System.Console.WriteLine("Digite a pontuação:");
                    string pont = Console.ReadLine();
                    t.times.Add(new Times(time, Int32.Parse(pont)));
                }
            } while (a.Key != ConsoleKey.D2);

            System.Console.WriteLine("Tabela");
            t.resultado();
        }
    }
}
