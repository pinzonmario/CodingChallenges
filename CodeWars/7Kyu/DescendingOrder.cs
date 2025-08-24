using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._7Kyu
{
    public class DescendingOrder
    {
        public static int SolutionA(int num)
        {
            return int.Parse(string.Join("", num.ToString().ToList().OrderByDescending(x => x)));
        }
    }
}
