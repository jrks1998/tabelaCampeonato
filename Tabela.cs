using System;
using System.Collections.Generic;

namespace tabelaCampeonato
{
    class Tabela
    {
        public List<Times> times = new List<Times>();
        public void tabela() {
            System.Console.WriteLine("Menu:");
            System.Console.WriteLine("Enter - Adiciona time e pontuação \n0 - Finaliza e exibe a tabela");

            while (Console.ReadKey().Key == ConsoleKey.Enter) {
                System.Console.WriteLine("Informe o nome do time: ");
                string time = Console.ReadLine();

                System.Console.WriteLine("Informe a pontuação do time: ");
                int pont = Convert.ToInt32(Console.ReadLine());

                this.times.Add(new Times(time, pont));
            }

            for (int i = 0; i < times.Count; i++) {
                times[i].dados();
            }
        }
    }
}