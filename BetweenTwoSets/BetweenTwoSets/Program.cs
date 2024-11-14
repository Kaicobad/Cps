using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenTwoSets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> brr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(brrTemp => Convert.ToInt32(brrTemp)).ToList();

            int total = getTotalX(arr, brr);

            Console.WriteLine(total);
            Console.ReadLine();
        }

        private static int getTotalX(List<int> a, List<int> b)
        {
            int MaxA = a.Max();
            int MinB = b.Min();
            int count = 0;

            for (int x = MaxA; x <= MinB; x++) 
            {
                var MultitplesOfA = a.All(num => x % num == 0);
                var FactorsOfB = b.All(num => num % x == 0);
                if (MultitplesOfA && FactorsOfB)
                {
                    count++;
                }
            }

            return count;
        }
    }
}
