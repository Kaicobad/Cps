using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakingTheRecord
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> scores = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(scoresTemp => Convert.ToInt32(scoresTemp)).ToList();

            List<int> result = breakingRecords(scores);

            Console.WriteLine(String.Join(" ", result));

            Console.ReadLine();
        }

        public static List<int> breakingRecords(List<int> scores)
        {
            int n = scores.Count;
            int hScore = scores[0];
            int lScore = scores[0];
            int hCount = 0;
            int lCount = 0;
            List<int> list = new List<int>();
            for (int i = 1; i < n; i++)
            {
                int value = scores[i];
                if (value > hScore)
                {
                    hCount++;
                    hScore = value;

                }
                if (value < lScore)
                {
                    lCount++;
                    lScore = value;
                }
            }
            list.Add(hCount);
            list.Add(lCount);

            return list;
        }

    }
}
