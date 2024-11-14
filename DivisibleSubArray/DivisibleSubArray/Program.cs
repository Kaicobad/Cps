using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivisibleSubArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int n = Convert.ToInt32(firstMultipleInput[0]);

            int k = Convert.ToInt32(firstMultipleInput[1]);

            List<int> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt32(arTemp)).ToList();
           

            int result = divisibleSumPairs(ar.Count, k, ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int divisibleSumPairs(int n, int k, List<int> ar)
        {
            int count = 0;
            for (int i = 0; i < n; i++) 
            {
                for(int j = 0; j < n; j++)
                {
                    if (i<j)
                    {
                        if((ar[i] + ar[j]) % k == 0)
                        {
                            count++;
                        }
                    }
                }
            }
            return count;
        }
    }
}
