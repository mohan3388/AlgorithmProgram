using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsProblem
{
    public class Anagram
    {
        public bool AnagramProblem(string Firstlength, string SecondLength)
        {
            var val1 = Firstlength.ToLower().ToArray();
            var val2 = SecondLength.ToLower().ToArray();
            Array.Sort(val1);
            Array.Sort(val2);
            return new string(val1) == new string(val2);
        }
    }
}
