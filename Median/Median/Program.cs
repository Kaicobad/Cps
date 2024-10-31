using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Median
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arrSize = Convert.ToInt32(Console.ReadLine().Trim());
            List<int> arr = new List<int>(arrSize);
            arr = Console.ReadLine().Trim().Split(' ').Select(x=> Convert.ToInt32(x)).ToList();
            int mdan = findMedian(arr);
            Console.WriteLine(mdan);
            Console.ReadLine();

        }
        public static int findMedian(List<int> arr)
        {
            arr.Sort();

            int mdn = arr[(arr.Count - 1) / 2];
            return mdn;
           
        }
    }
}
