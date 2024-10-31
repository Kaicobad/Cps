using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeConversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string time = Console.ReadLine().Trim();

            var response =  timeConversion(time);
            Console.WriteLine(response);
            Console.ReadLine();
        }
        public static string timeConversion(string s)
        {

            DateTime outputTime;

            var res = DateTime.ParseExact(s, "hh:mm:sstt",System.Globalization.CultureInfo.InvariantCulture,DateTimeStyles.None).ToString("HH:mm:ss");

            //Console.WriteLine("res: " + res);

            return res;
        }
    }
}
