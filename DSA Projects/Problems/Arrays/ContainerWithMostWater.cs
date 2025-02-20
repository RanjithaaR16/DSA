using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace DSA_Projects.Problems.Arrays
{
    public static class ContainerWithMostWater
    {
        public static int Execute(int[] height)
        {
            int maxWater = 0;
            int currentMaxWater = 0;
            int distance = 0;
            int leftmax = 0;
            int rightmax = height.Length - 1;
            while(leftmax < rightmax)
            {
                // To calculate distance
                distance = rightmax - leftmax;
                currentMaxWater = distance * Math.Min(height[leftmax], height[rightmax]);

                if(currentMaxWater > maxWater)
                {
                    maxWater = currentMaxWater;
                }

                if (height[leftmax] < height[rightmax]) 
                    leftmax++;
                else
                    rightmax--;
            }
            return maxWater;
        }

        public static int Run()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            return Execute(height);
        }
    }
}
//11.Container With Most Water
//You are given an integer array height of length n. There are n vertical lines drawn such that the two endpoints of the ith line are (i, 0) and (i, height[i]).

//Find two lines that together with the x-axis form a container, such that the container contains the most water.

//Return the maximum amount of water a container can store.

//Notice that you may not slant the container.

//Example 1:


//Input: height = [1, 8, 6, 2, 5, 4, 8, 3, 7]
//Output: 49
//Explanation: The above vertical lines are represented by array [1, 8, 6, 2, 5, 4, 8, 3, 7].In this case, the max area of water(blue section) the container can contain is 49.
//Example 2:

//Input: height = [1, 1]
//Output: 1



//Constraints:

//    n == height.length
//2 <= n <= 105
//0 <= height[i] <= 104
