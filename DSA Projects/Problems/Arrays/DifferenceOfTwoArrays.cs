using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projects.Problems.Arrays
{
    public static class DifferenceOfTwoArrays
    {
        public static IList<IList<int>> Execute(int[] nums1, int[] nums2)
        {
            IList<IList<int>> result = new List<IList<int>>();
            List<int> result1 = new List<int>();
            List<int> result2 = new List<int>();

            HashSet<int> nums1Set = new HashSet<int>(nums1);
            HashSet<int> nums2Set = new HashSet<int>(nums2);

            foreach (int i in nums1Set)
            {
                if(!nums2Set.Contains(i))
                    result1.Add(i);
            }
            result.Add(result1);
            foreach (int i in nums2Set)
            {
                if (!nums1Set.Contains(i))
                    result2.Add(i);
            }
            result.Add(result2);
            return result;
        }

        public static IList<IList<int>> Run()
        {
            int[] nums1 = { 1, 2, 3 };
            int[] nums2 = { 2, 4, 6 };
            return Execute(nums1, nums2);
        }
    }
}

//2215.Find the Difference of Two Arrays
//Given two 0-indexed integer arrays nums1 and nums2, return a list answer of size 2 where:

//answer[0] is a list of all distinct integers in nums1 which are not present in nums2.
//answer[1] is a list of all distinct integers in nums2 which are not present in nums1.
//Note that the integers in the lists may be returned in any order.



//Example 1:

//Input: nums1 = [1, 2, 3], nums2 = [2, 4, 6]
//Output: [[1,3],[4,6]]
//Explanation:
//For nums1, nums1[1] = 2 is present at index 0 of nums2, whereas nums1[0] = 1 and nums1[2] = 3 are not present in nums2. Therefore, answer[0] = [1, 3].
//For nums2, nums2[0] = 2 is present at index 1 of nums1, whereas nums2[1] = 4 and nums2[2] = 6 are not present in nums2. Therefore, answer[1] = [4, 6].
//Example 2:

//Input: nums1 = [1, 2, 3, 3], nums2 = [1, 1, 2, 2]
//Output: [[3],[]]
//Explanation:
//For nums1, nums1[2] and nums1[3] are not present in nums2. Since nums1[2] == nums1[3], their value is only included once and answer[0] = [3].
//Every integer in nums2 is present in nums1. Therefore, answer[1] = [].


//Constraints:

//1 <= nums1.length, nums2.length <= 1000
//- 1000 <= nums1[i], nums2[i] <= 1000
