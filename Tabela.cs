using System;
using System.Collections.Generic;
using System.Linq;

namespace tabelaCampeonato
{
    class Tabela
    {
        public List<Times> times;

        public Tabela() {
            times = new List<Times>();
        }

        public void resultado() {
            times.ForEach(delegate(Times t) {
                t.pont.CompareTo(t.pont);
                times.Sort();
                System.Console.WriteLine($"Time: {t.time} | Pontuação: {t.pont}");
            });
        }
            
    }
}