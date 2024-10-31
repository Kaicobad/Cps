using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StairCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 4;

            staircase(n);
        }
        public static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = n - i; j > 0; j--)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i; k++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
               
            }
            Console.ReadLine();
        }
    }
}
