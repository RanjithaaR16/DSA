using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA_Projects.Problems.Arrays
{
    internal class FindDuplicatesinArray
    {
        public static IList<int> Execute(int[] nums)
        {
            List<int> result = new List<int>();
            Dictionary<int,int> map = new Dictionary<int,int>();
            foreach (int num in nums)
            {
                if (!map.ContainsKey(num))
                    map.Add(num, 1);
                else
                {
                    map[num]++;
                    result.Add(num);
                }
                    
            }
            return result;
        }

        public static IList<int> Run()
        {
            int[] nums = { 4, 3, 2, 7, 8, 2, 3, 1 };
            return Execute(nums);
        }
    }
}

//442.Find All Duplicates in an Array
//Given an integer array nums of length n where all the integers of nums are in the range [1, n]
//and each integer appears at most twice, return an array of all the integers that appears twice.

//You must write an algorithm that runs in O(n) time and uses only constant auxiliary space, excluding the space needed to store the output

 

//Example 1:

//Input: nums = [4, 3, 2, 7, 8, 2, 3, 1]
//Output: [2,3]
//Example 2:

//Input: nums = [1, 1, 2]
//Output: [1]
//Example 3:

//Input: nums = [1]
//Output: []


//Constraints:

//n == nums.length
//1 <= n <= 105
//1 <= nums[i] <= n
//Each element in nums appears once or twice.
