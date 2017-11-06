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
        public static List<char> nennungen = new List<char>() { 'a', 'b', 'Z', 'L', 'q', 'C', 'M', 'b', 'Z', 'L', 'q', 'C', 'M', 'b', 'Z', 'L', 'q', 'C', 'M', 'b', 'Z', 'L', 'q', 'C', 'M', 'a', 'b', 'Z', 'L', 'q', 'C', 'M', 'b' };    // 'a', 'b', 'Z', 'L', 'q', 'C', 'M'


        

        static void Main(string[] args)
        {
            WriteLine("Anzahl der Nennungen: {0}", nennungen.Count);

            var query = from anzahl in nennungen group nennungen by nennungen into neueAnzahl select new { a = neueAnzahl.Count() };
            {
                foreach ( var item in query )
                {
                    WriteLine(item.a);
                }
            }
            ReadLine();
        }
    }
}
