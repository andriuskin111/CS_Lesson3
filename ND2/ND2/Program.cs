using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ND2
{
    class Program
    {
        static void Main(string[] args)
        {
            int pazimys;
            if (!int.TryParse(Console.ReadLine(), out pazimys))
            {
                Console.WriteLine("Ivesti neteisingi duomenys");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if((pazimys> 10) || (pazimys < 0))
            {
                Console.WriteLine("Ivesti neteisingi duomenys");
                Console.ReadLine();
                Environment.Exit(0);
            }

            switch(pazimys)
            {
                case 0:
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 1:
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 2:
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 3:
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 4:
                    Console.WriteLine("NEPATENKINAMAI");
                    break;
                case 5:
                    Console.WriteLine("SILPNAI");
                    break;
                case 6:
                    Console.WriteLine("PATENKINAMAI");
                    break;
                case 7:
                    Console.WriteLine("VIDUTINISKAI");
                    break;
                case 8:
                    Console.WriteLine("GERAI");
                    break;
                case 9:
                    Console.WriteLine("LABAI GERAI");
                    break;
                case 10:
                    Console.WriteLine("PUIKIAI");
                    break;
            }

            Console.ReadLine();
        }
    }
}
