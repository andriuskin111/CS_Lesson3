﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KD2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal skaicius1 = 0.1m * 10;
            decimal skaicius2 = 0m;

            for(int ctr = 0; ctr < 10; ctr++)
            {
                skaicius2 += 0.1m;
            }

            Console.WriteLine("{0} = {1} : {2}", skaicius1, skaicius2, skaicius1==skaicius2);
            Console.ReadLine();
        }
    }
}
