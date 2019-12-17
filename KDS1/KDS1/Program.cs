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
            char pirmasSimbolis = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Iveskite pirma simboli");
            char antrasSimbolis = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Iveskite pirma simboli");
            char treciasSimbolis = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Simboliai atvirkstine tvarka: {0} {1} {2}", treciasSimbolis, antrasSimbolis, pirmasSimbolis);
            Console.ReadLine();
        }
    }
}
