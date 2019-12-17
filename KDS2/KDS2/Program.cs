using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite atstuma metrais");
            double atstumasKm = Convert.ToDouble(Console.ReadLine()) / 1000;
            Console.WriteLine("Iveskite laika skundem");
            double laikasMin = Convert.ToDouble(Console.ReadLine()) / 3600;

            double greitis = atstumasKm / laikasMin;

            Console.WriteLine("Greitis Km/h: {0}", greitis );
            Console.ReadLine();
        }
    }
}
