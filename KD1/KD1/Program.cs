﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD1
{
    class Program
    {
        static void Main(string[] args)
        {
            float skaiciusFloat = 1f / 3;
            double skaiciusDouble = 1d / 3;

            if (skaiciusFloat == skaiciusDouble)
            {
                Console.WriteLine("skaiciusFloat {0} yra lygus skaiciusDouble {1}", skaiciusFloat, skaiciusDouble);
            }
            else
            {
                Console.WriteLine("skaisiuFloat {0} nera lygus skaiciusDouble {1}", skaiciusFloat, skaiciusDouble);
            }
            Console.ReadLine();
        }
    }
}
