using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleOrange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int s = Convert.ToInt32(firstMultipleInput[0]);

            int t = Convert.ToInt32(firstMultipleInput[1]);

            string[] secondMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int a = Convert.ToInt32(secondMultipleInput[0]);

            int b = Convert.ToInt32(secondMultipleInput[1]);

            string[] thirdMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            int m = Convert.ToInt32(thirdMultipleInput[0]);

            int n = Convert.ToInt32(thirdMultipleInput[1]);

            List<int> apples = new List<int>(m);
            List<int> oranges = new List<int>(n);

            apples = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(applesTemp => Convert.ToInt32(applesTemp)).ToList();
            oranges = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(orangesTemp => Convert.ToInt32(orangesTemp)).ToList();

            countApplesAndOranges(s, t, a, b, apples, oranges);
        }
        public static void countApplesAndOranges(int s, int t, int a, int b, List<int> apples, List<int> oranges)
        {
            //int idx = 0;

            int appCount = 0;
            int orangeCount = 0;


            for (int i = 0; i < apples.Count; i++) 
            {
                apples[i] = apples[i] + a;
                if (apples[i] >= s && apples[i] <= t)
                {
                    appCount++;
                }
            }
            for (int i = 0; i < oranges.Count; i++)
            {
                oranges[i] = oranges[i] + b;
                if (oranges[i] >= s && oranges[i] <= t)
                {
                    orangeCount++;
                }
            }

            Console.WriteLine(appCount);
            Console.WriteLine(orangeCount);
            Console.ReadLine();
        }

    }
}
