using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BirthdayCakeCanldle
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int arrSize = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = new List<int>(arrSize);

            arr = Console.ReadLine().Trim().Split(' ').Select(x => Convert.ToInt32(x)).ToList();

            var response = tallestcandleCount(arr);

            Console.WriteLine(response);
            Console.ReadLine();

        }

        public static int tallestcandleCount (List<int> candles)
        {
            int tallestvalue = 0;
            int Count = 0;
            for (int i = 0; i < candles.Count; i++)
            {
                tallestvalue = candles.Max();

                if (tallestvalue == candles[i])
                {
                    Count++;
                }
            }

            return Count;
        }
    }
}
