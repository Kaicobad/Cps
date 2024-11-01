﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalDiffirence
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> arr = new List<List<int>>();

            for (int i = 0; i < n; i++)
            {
                arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            }

            int result = diagonalDifference(arr);

            Console.WriteLine(result);

            Console.ReadLine();

        }
        public static int diagonalDifference(List<List<int>> arr)
        {
            int result = 0;

            int n = arr.Count;

            for (int i = 0; i < n; i++) 
            {
                result = result + arr[i][i] - arr[i][n-1-i];
            }

            return Math.Abs(result);
        }
    }
}
