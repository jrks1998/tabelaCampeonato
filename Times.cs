using System;

namespace tabelaCampeonato
{
    class Times
    {
        private string time;
        private int pont;

        public Times(string nomeTime, int pontuacao) {
            this.time = nomeTime;
            this.pont = pontuacao;
        }

        public void dados() {
            System.Console.WriteLine("\ntime: " + time + " | pontuação: " + pont);
        }
    }
} 