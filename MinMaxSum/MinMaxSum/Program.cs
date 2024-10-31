using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(e => Convert.ToInt32(e)).ToList();
            minMaxSum(arr);
        }
        public static void minMaxSum(List<int> arr)
        {
            int Min = 0;
            int Max = 0;
            int res = 0;

            for (int i = 0; i < arr.Count; i++) 
            {
                res += arr[i];
                if (i > 0)
                {
                    if (arr[i] > Max)
                    {
                        Max = arr[i];
                    }
                    else if (arr[i] < Min) 
                    {
                        Min = arr[i];
                    }
                }
            }

            var MaxNum = res - Min;
            var MinNum = res - Max;

            Console.WriteLine($"{MinNum} {MaxNum}");
            Console.ReadLine();
        }
    }
}
