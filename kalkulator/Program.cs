﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("0. Exit");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Diff");
                Console.WriteLine("3. Mul\n");

                int menuOptions = Convert.ToInt32(Console.ReadLine());
                if (menuOptions == 0)
                {
                    break;
                }
            }
        }
    }
}
