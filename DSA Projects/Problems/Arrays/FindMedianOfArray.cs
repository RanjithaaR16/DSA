using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projects.Problems.Arrays
{
    public static class FindMedianOfArray
    {
        public static double Execute(int[] nums1, int[] nums2)
        {
            double result = 0;
            int[] mergedArray = nums1.Concat(nums2).ToArray();
            Array.Sort(mergedArray);

            bool isEvenArray = mergedArray.Length % 2 == 0;

            if (isEvenArray)
            {
                int medianIndex = (int)Math.Ceiling((double)mergedArray.Length / 2);

                int left = mergedArray[medianIndex - 1];
                int right = mergedArray[medianIndex];
                result = (double)(left + right) / 2;
            }
            else
            {
                int medianIndex = (int)Math.Ceiling((double)mergedArray.Length / 2);

                result = mergedArray[medianIndex - 1];
            }

            return result;
        }
        public static double Run()
        {
            int[] nums1 = { 2, 2, 4, 4 }; int[] nums2 = { 2, 2, 2, 4, 4 };
            return Execute(nums1, nums2);
        }
    }
}
//4.Median of Two Sorted Arrays
//Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

//The overall run time complexity should be O(log (m+n)).



//Example 1:

//Input: nums1 = [1, 3], nums2 = [2]
//Output: 2.00000
//Explanation: merged array = [1, 2, 3] and median is 2.
//Example 2:

//Input: nums1 = [1, 2], nums2 = [3, 4]
//Output: 2.50000
//Explanation: merged array = [1, 2, 3, 4] and median is (2 + 3) / 2 = 2.5.


//Constraints:

//nums1.length == m
//nums2.length == n
//0 <= m <= 1000
//0 <= n <= 1000
//1 <= m + n <= 2000
//- 106 <= nums1[i], nums2[i] <= 106
