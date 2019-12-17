using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite grupes nariu skaiciu:");
            int nariuSkaicius;

            if (!int.TryParse(Console.ReadLine(), out nariuSkaicius))
            {
                Console.WriteLine("Ivestas nekorektiskas skaicius");
                Console.ReadLine();
                Environment.Exit(0);
            }

            if (nariuSkaicius == 1)
            {
                Console.WriteLine("Tai solo atlikejas");
            }
            else if(nariuSkaicius == 2)
            {
                Console.WriteLine("Tai duetas");
            }
            else if((nariuSkaicius > 2) && (nariuSkaicius < 10))
            {
                Console.WriteLine("Tai ansamblis");
            }
            else if(nariuSkaicius > 10)
            {
                Console.WriteLine("Tai kamerinis ansamblis");
            }
            else
            {
                Console.WriteLine("Ivestas nekorektiskas skaicius");
            }

            Console.ReadLine();
        }
    }
}
