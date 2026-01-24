using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Easy
{
    public class PalindromeNumber
    {
        public static bool Solution(int x)
        {
            string value = x.ToString();
            return value.SequenceEqual(value.Reverse());
        }
    }
}
