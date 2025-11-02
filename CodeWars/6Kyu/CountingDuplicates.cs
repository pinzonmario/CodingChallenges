using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars._6Kyu
{
    public class CountingDuplicates
    {
        public static int SolutionA(string str)
        {
            var text = str.ToLower();

            var duplicates = text.GroupBy(x => x)
                                 .Where(x => x.Count() > 1)
                                 .Select(x => x.Key);

            return duplicates.Count();
        }
    }
}
