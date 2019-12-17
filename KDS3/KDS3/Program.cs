using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KDS3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iveskite rutulio diametra");
            double rutulioDiametras = Convert.ToDouble(Console.ReadLine());
            double rutulioSpindulys = rutulioDiametras / 2;
            double rutulioPlotas = 4 * Math.PI * Math.Sqrt(rutulioDiametras);
            double rutulioTuris = (4 / 3) * Math.PI * Math.Pow(rutulioPlotas, 3);

            Console.WriteLine("Rutulio plotas: {0}", rutulioPlotas);
            Console.WriteLine("Rutulio plotas: {0}", rutulioTuris);
            Console.ReadLine();
        }
    }
}
