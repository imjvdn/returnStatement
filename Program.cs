﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace returnStatement
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubedNumber = cube(10);
            Console.WriteLine(cubedNumber);
            //Console.WriteLine(cube(5));
            Console.ReadLine();

        }

        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
    }
}
