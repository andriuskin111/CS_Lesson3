using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KS6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskirte spalva");
            string spalva = Console.ReadLine();

            if ((spalva == "geltona") || (spalva == "zalia") || (spalva == "raudona"))
                Console.WriteLine("spalva yra trispalvej");
            else
                Console.WriteLine("spalv ne trispalvej");
        }
    }
}
