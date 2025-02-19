using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projects.Problems.Arrays
{
    public static class FindDisappearedNumbers
    {
        // Approach 1
        public static IList<int> Execute(int[] nums)
        {
            IList<int> result = new List<int>();
            Dictionary<int,int> arrValue = new Dictionary<int,int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (!arrValue.ContainsKey(nums[i]))
                    arrValue.Add(nums[i], 1);
                else
                    arrValue[nums[i]]++;
            }
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!arrValue.ContainsKey(i))
                    result.Add(i);
            }
            return result;
        }

        // Approach 2 - with has set
        public static IList<int> ExecuteHashSet(int[] nums)
        {
            IList<int> result = new List<int>();
            HashSet<int> arrValue = new HashSet<int>(nums);
            
            for (int i = 1; i <= nums.Length; i++)
            {
                if (!arrValue.Contains(i))
                    result.Add(i);
            }
            return result;
        }

        public static IList<int> Run()
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            return ExecuteHashSet(nums);
        }
    }
}

//448.Find All Numbers Disappeared in an Array
    //Given an array nums of n integers where nums[i] is in the range[1, n], return an array of all the integers in the range [1, n] that do not appear in nums.



//Example 1:

//Input: nums = [4, 3, 2, 7, 8, 2, 3, 1]
//Output: [5,6]
//Example 2:

//Input: nums = [1, 1]
//Output: [2]


//Constraints:

//n == nums.length
//1 <= n <= 105
//1 <= nums[i] <= n


