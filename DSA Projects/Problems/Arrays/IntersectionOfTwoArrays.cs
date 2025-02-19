using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projects.Problems.Arrays
{
    public static class IntersectionOfTwoArrays
    {
        public static int[] Execute(int[] nums1, int[] nums2)
        {
            List<int> result = new List<int>();
            Dictionary<int,int> map = new Dictionary<int,int>();
            
            // Step 1: Add the nums1 values to dictionary
            for (int i = 0; i < nums1.Length; i++)
            {
                if (!map.ContainsKey(nums1[i]))
                    map.Add(nums1[i], 1);
                else
                    map[nums1[i]]++;
            }

            // Step 2: Loop through nums2 and find the intersection
            for (int i = 0; i < nums2.Length; i++)
            {
                if (map.ContainsKey(nums2[i]))
                {
                    result.Add(nums2[i]);
                    map[nums2[i]]--;
                    if (map[nums2[i]] == 0)
                        map.Remove(nums2[i]);
                }
            }
            return result.ToArray();
        }

        public static int[] Run()
        {
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = {2, 2};
            return Execute(nums1, nums2);
        }
    }
}

//350.Intersection of Two Arrays II
//Given two integer arrays nums1 and nums2, return an array of their intersection. Each element in the result must appear as many times as it shows in both arrays and you may return the result in any order.



//Example 1:

//Input: nums1 = [1, 2, 2, 1], nums2 = [2, 2]
//Output: [2,2]
//Example 2:

//Input: nums1 = [4, 9, 5], nums2 = [9, 4, 9, 8, 4]
//Output: [4,9]
//Explanation: [9, 4] is also accepted.


//Constraints:

//1 <= nums1.length, nums2.length <= 1000
//0 <= nums1[i], nums2[i] <= 1000



//Follow up:

//What if the given array is already sorted? How would you optimize your algorithm?
//What if nums1's size is small compared to nums2's size? Which algorithm is better?
//What if elements of nums2 are stored on disk, and the memory is limited such that you cannot load all elements into the memory at once?
