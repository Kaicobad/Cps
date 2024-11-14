using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubArrayDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> s = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(sTemp => Convert.ToInt32(sTemp)).ToList();

            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int d = Convert.ToInt32(firstMultipleInput[0]);

            int m = Convert.ToInt32(firstMultipleInput[1]);

            int result = birthday(s, d, m);

            Console.WriteLine(result);

            Console.ReadLine();
        }

        private static int birthday(List<int> s, int d, int m)
        {
            int count = 0;
            List<int> arr = s;

            for (var i = 0; i <= arr.Count ; i++)
            {
                int sum = 0;
                for (int j = i; j < m +i; j++)
                {
                    if (j == arr.Count)
                    {
                        break;
                    }
                    else
                    {
                        sum = sum + arr[j];
                    }
                   
                }
                if (sum == d)
                {
                     count++;
                }
            }

            return count;
        }

    }
}
