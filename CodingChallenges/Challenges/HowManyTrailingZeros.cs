using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenges.Challenges
{
    /*Write a program that will calculate the number of trailing zeros in a factorial of a given number.

N! = 1 * 2 * 3 *  ... * N

Be careful 1000! has 2568 digits...

For more info, see: http://mathworld.wolfram.com/Factorial.html
Examples
N 	Product 	N factorial 	Trailing zeros
6 	1*2*3*4*5*6 	720 	1
12 	1*2*3*4*5*6*7*8*9*10*11*12 	479001600 	2

Hint: You're not meant to calculate the factorial. Find another way to find the number of zeros.
*/
    public class HowManyTrailingZeros
    {
        public static int TrailingZeros(int n)
        {
            //Solution
            //If I thnk about this as follows,
            //when n = 5 it has 1 trailing 0s.
            //when n = 10 it has 2 trailing 0s.
            //when n = 15 it has 3 trailing 0s. 
            //so that could be true for all remaining numbers.
            //So, I can divide N by 5 and the result is then how many trailing zeros there are.
            //but at 25 it becomes 6 and not 5...
            //so I can divide N by 5 and then divide the result by 5 and so on until the result is less than 5.

            int total = 0;

            while (n >= 5)
            {
                n = n / 5;
                total += n;
            }

            return total;
        }
    }
}
