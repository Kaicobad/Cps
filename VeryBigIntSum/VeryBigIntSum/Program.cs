using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeryBigIntSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<long> ar = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arTemp => Convert.ToInt64(arTemp)).ToList();

            long result = aVeryBigSum(ar);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static long aVeryBigSum(List<long> ar)
        {
            long res = 0;

            for (int i = 0; i < ar.Count; i++)
            {
                res = res + ar[i]; 
            }

            return res;
        }
    }
}
