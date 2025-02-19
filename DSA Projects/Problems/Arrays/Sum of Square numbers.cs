using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projects.Problems.Arrays
{
    public class Sum_of_Square_numbers
    {
        //Approach 1 - exceeding time limit
        public static bool Execute(int c)
        {
            long sum = 0;
            for (int i = 0; i <= Math.Sqrt(c); i++)
            {
                for (int j = 0; j <= Math.Sqrt(c); j++)
                {
                    sum = (i * i) + (j * j) ;
                    if (sum == c)
                        return true;
                    
                }

            }
            return false;
        }

        //Approach 2 - Two pointer - works find accepted solution
        public static bool ExecuteTwoPointer(int c)
        {
            long sum = 0;
            long left = 0;
            long right = (long)(Math.Sqrt(c));
            while (left <= right)
            {
                sum = (left * left) + (right * right);
                if (sum == c)
                    return true;
                else if (sum < c)
                    left++;
                else
                    right--;
            }
            return false;
        }

        public static bool Run()
        {
            int c = 2;
            return ExecuteTwoPointer(c);
        }
    }
}

//Given a non-negative integer c, decide whether there're two integers a and b such that a2 + b2 = c.

 

//Example 1:

//Input: c = 5
//Output: true
//Explanation: 1 * 1 + 2 * 2 = 5
//Example 2:

//Input: c = 3
//Output: false

//Constraints:

//0 <= c <= 231 - 1
