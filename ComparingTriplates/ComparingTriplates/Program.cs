using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparingTriplates
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> a = new List<int>() { 2,6,6,3};
            List<int> b = new List<int>() { 3,5,7,3};

            var result = compareTriplets(a,b);

            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int res1 = 0;
            int res2 = 0;
            int idx = 0;

            List<int> result = new List<int>(); 

            while (idx < a.Count && idx < b.Count)
            {
                if (a[idx] > b[idx])
                {
                    res1 = res1 + 1;
                    idx++;
                }
                else if (b[idx] > a[idx])
                {
                    res2 = res2 + 1;
                    idx++;
                }
                else
                {
                    res1 = res1 + 0;
                    res2 = res2 + 0;
                    idx++;
                }
            }

            result.Add(res1);
            result.Add(res2);
            return result;

        }
    }
}
