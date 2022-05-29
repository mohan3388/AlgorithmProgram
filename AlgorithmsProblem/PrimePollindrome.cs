using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsProblem
{
    public class PrimePollindrome
    {
        public void PollindromePrime()
        {
            Console.WriteLine("The prime pollindromes are: ");
            int i, j, count,temp,rev;
            for (i = 1; i <= 1000; i++)
            {
                temp = i;
                count = 0;
                rev = 0;
                for (j = 1; j <= temp; j++)
                {

                    if (temp % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    while(temp>0)
                    {
                        rev = rev*10+(temp%10);
                        temp = temp/10;
                    }
                    if (rev == i)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}
