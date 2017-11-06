using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ABCAnalyse_ConsoleApplication
{
    class Program
    {
        public static List<char> nennungen = new List<char>() { 'a', 'b', 'Z', 'L', 'q', 'C', 'M', 'b', 'Z', 'L', 'q', 'C', 'M', 'b', 'Z', 'L', 'q', 'C', 'M', 'b', 'Z', 'L', 'q', 'C', 'M' };    // 'a', 'b', 'Z', 'L', 'q', 'C', 'M'


        

        static void Main(string[] args)
        {
            WriteLine("Anzahl der Nennungen: {0}", nennungen.Count);

            // var query = from anzahl in nennungen group anzahl by anzahl into neueAnzahl select new { treffer = neueAnzahl.Count() }; // zählt Buchstaben
            // var query = from anzahl in nennungen group nennungen by nennungen into neueAnzahl select new { alle = neueAnzahl.Count() };    // zählt alle
            // var query = from anzahl in nennungen group anzahl by anzahl into neueAnzahl select new { treffer = neueAnzahl.Count(), wer = nennungen };   // Buchstabe wie oft
            var query = from anzahl in nennungen group anzahl by anzahl into neueAnzahl
                        select new { treffer = neueAnzahl.Count(), wer = neueAnzahl.First() }; // Buchstabe wie oft, welcher genau
            {
                foreach ( var item in query )
                {
                    WriteLine("{0}, {1}", item.treffer, item.wer);
                }
            }
            ReadLine();
        }
    }
}
