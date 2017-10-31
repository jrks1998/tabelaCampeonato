using System;

namespace tabelaCampeonato
{
    class Tabela
    {
        public void time() {
            System.Console.WriteLine("menu:");
            System.Console.WriteLine("1 - Adiciona time e sua respectiva pontuação \n2 - Finaliza o programa");

            while (Console.ReadKey().Key != ConsoleKey.Oem2) {
                System.Console.WriteLine("oi");
            }
        }
    }
}