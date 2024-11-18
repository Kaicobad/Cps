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
            int maxCount = 0;
            int result = int.MaxValue;

            Dictionary<int,int> birds = new Dictionary<int,int>();
            foreach (int birdsIds in arr) 
            {
                if (birds.ContainsKey(birdsIds))
                {
                    birds[birdsIds]++;
                }
                else 
                {
                    birds[birdsIds] = 1;
                }
            }
            foreach (var item in birds)
            {
                if (item.Value > maxCount ||(item.Value == maxCount && item.Key < result))
                {
                    maxCount = item.Value;
                    result = item.Key;
                }
            }
            return result;
        }
    }
}
