using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Migratorybirds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            int result = migratoryBirds(arr);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        private static int migratoryBirds(List<int> arr)
        {
            int maxcount = 0;
            int rem = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                int count = 0;
                for (int j = 0; j < arr.Count; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count > maxcount)
                {
                    maxcount = count;
                    rem = arr[i];
                }
            }
            return rem;
        }
    }
}
