using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinusRatio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            plusMinus(arr);

        }

        public static void plusMinus(List<int> arr)
        {
            int posRes = 0;
            int negRes = 0;
            int zeroRes = 0;

            for (int i = 0; i < arr.Count; i++) 
            {
                if (arr[i] > 0)
                {
                    posRes++;
                }
                else if (arr[i] < 0)
                {
                    negRes++;
                }
                else
                {
                    zeroRes++;
                }
            }

            string posRatio = Math.Round(((decimal)posRes / arr.Count),6).ToString("F6");
            string negRatio = Math.Round(((decimal)negRes / arr.Count), 6).ToString("F6");
            string zeroRatio = Math.Round(((decimal)zeroRes / arr.Count), 6).ToString("F6");

            List<string> arrTemp = new List<string>();

            arrTemp.Add(posRatio);
            arrTemp.Add(negRatio);
            arrTemp.Add(zeroRatio);

            var  result = string.Join(separator: "\n", arrTemp);

            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
