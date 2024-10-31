﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberLineJumps
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int x1 = Convert.ToInt32(firstMultipleInput[0]);

            int v1 = Convert.ToInt32(firstMultipleInput[1]);

            int x2 = Convert.ToInt32(firstMultipleInput[2]);

            int v2 = Convert.ToInt32(firstMultipleInput[3]);

            string result = kangaroo(x1, v1, x2, v2);

            Console.WriteLine(result);

            Console.ReadLine();
        }
        public static string kangaroo(int x1, int v1, int x2, int v2)
        {
            if (x2>x1 && v2>v1)
            {
                return "NO";
            }
            else if ((x2 - x1) % Math.Abs(v2 - v1) == 0)
            {
                return "YES";
            }
            else 
            {
                return "NO";
            }
        }
    }
}
