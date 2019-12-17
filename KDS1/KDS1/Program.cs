using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite pirma simboli");
            char pirmasSimbolis = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Iveskite antra simboli");
            char antrasSimbolis = Console.ReadKey().KeyChar;
            Console.WriteLine();
            Console.WriteLine("Iveskite trecia simboli");
            char treciasSimbolis = Console.ReadKey().KeyChar;
            Console.WriteLine();

            Console.WriteLine("Simboliai atvirkstine tvarka: {0} {1} {2}", treciasSimbolis, antrasSimbolis, pirmasSimbolis);
            Console.ReadLine();
        }
    }
}
