using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradingStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int gradeNum = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> gradeList = new List<int>();

            for (int i = 0; i < gradeNum; i++)
            {
                int gradeitems = Convert.ToInt32(Console.ReadLine().Trim());

                gradeList.Add(gradeitems);
            }

            var response = gradingStudents(gradeList);
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            for (int i = 0; i < grades.Count; i++) 
            {
                
            }
            return null;
        }
    }
}
