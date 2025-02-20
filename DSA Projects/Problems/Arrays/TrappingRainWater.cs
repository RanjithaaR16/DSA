using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projects.Problems.Arrays
{
    public static class TrappingRainWater
    {
        public static int Execute(int[] height)
        {
            int[] leftMax = new int[height.Length];
            int[] rightMax = new int[height.Length];
            int totalWater = 0;

            leftMax[0] = height[0];
            for (int i = 1; i < height.Length; i++)
            {
                leftMax[i] = Math.Max(leftMax[i - 1], height[i]);
            }

            rightMax[height.Length - 1] = height[height.Length - 1];
            for (int i = height.Length - 2; i >= 0; i--)
            {
                rightMax[i] = Math.Max(rightMax[i + 1], height[i]);
            }

            for (int i = 0; i < height.Length - 1; i++)
            {
                totalWater += Math.Min(leftMax[i], rightMax[i]) - height[i];
            }
            return totalWater;
        }

        //Two pointer approach
        public static int ExecuteTwoPointer(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int leftMax = height[left];
            int rightMax = height[right];
            int totalWater = 0;

            while (left < right)
            {
                if (leftMax <= rightMax)
                {
                    totalWater += Math.Min(leftMax, rightMax) - height[left];
                    left++;
                    leftMax = Math.Max(leftMax, height[left]);
                }
                else
                {
                    totalWater += Math.Min(leftMax, rightMax) - height[right];
                    right--;
                    rightMax = Math.Max(rightMax, height[right]);

                }
            }

            return totalWater;
        }

        //Two pointer approach -  Efficient approach
        public static int ExecuteTwoPointerApproach2(int[] height)
        {
            int left = 0;
            int right = height.Length - 1;
            int leftMax = 0;
            int rightMax = 0;
            int totalWater = 0;

            while (left < right)
            {
                if (height[left] <= height[right])
                {
                    if(leftMax <= height[left])
                        leftMax = height[left];
                    else
                        totalWater += leftMax - height[left];
                    left++;

                }
                else
                {
                    if(rightMax <= height[right])
                        rightMax = height[right];
                    else
                        totalWater += rightMax - height[right];
                    right--;

                }
            }
            return totalWater;
        }

        public static int Run()
        {
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };
            return ExecuteTwoPointerApproach2(height);
        }
    }
}

//42.Trapping Rain Water

//Given n non-negative integers representing an elevation map where the width of each bar is 1,
//compute how much water it can trap after raining.

//Example 1:

//Input: height = [0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1]
//Output: 6
//Explanation: The above elevation map(black section) is represented by array[0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1].
//In this case, 6 units of rain water(blue section) are being trapped.

//Example 2:

//Input: height = [4, 2, 0, 3, 2, 5]
//Output: 9

//Constraints:

//n == height.length
//1 <= n <= 2 * 104
//0 <= height[i] <= 105
