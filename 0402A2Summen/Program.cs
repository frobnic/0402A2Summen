using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0402A2Summen
{
    class Program
    {
        static void Main(string[] args)
        {
            long n=0; // Eingabevariable
            long i=0; // Schleifenvariable
            long s=0; // Summe

            Console.Write("Bitte geben Sie eine Ganzzahl ein : ");
            if (long.TryParse(Console.ReadLine(), out n))
            {
                for ( i = 0; i <= n; i++)
                {
                    s = s + i;
                }
                Console.WriteLine();
                Console.WriteLine("Die Summe aller Zahlen von 0 bis {0} ist {1}", n, s);
                Console.WriteLine();
            }
        }
    }
}
