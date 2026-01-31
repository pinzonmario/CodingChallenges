using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Easy
{
    public class PlusMinus
    {
        public static void Solution(List<int> arr)
        {
            int totalPositives = arr.Count(x => x > 0);
            int totalNegatives = arr.Count(x => x < 0);
            int totalZeros = arr.Count(x => x == 0);

            double positiveRatio = (double)totalPositives / arr.Count;
            double negativeRatio = (double)totalNegatives / arr.Count;
            double zeroRatio = (double)totalZeros / arr.Count;

            Console.WriteLine(positiveRatio.ToString("f6"));
            Console.WriteLine(negativeRatio.ToString("f6"));
            Console.WriteLine(zeroRatio.ToString("f6"));
        }
    }
}
