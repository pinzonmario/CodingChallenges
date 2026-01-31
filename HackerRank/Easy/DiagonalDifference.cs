using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Easy
{
    public class DiagonalDifference
    {
        public static int Solution(List<List<int>> arr)
        {
            int d1 = 0;
            int d2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                for (int j = i; j <= i; j++)
                {
                    d1 += arr[i][j];
                    d2 += arr[i][arr.Count - 1 - i];
                }
            }

            return Math.Abs(d1 - d2);
        }
    }
}
