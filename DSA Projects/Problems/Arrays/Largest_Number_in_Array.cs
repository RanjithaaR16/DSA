using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DSA_Projects.Problems.Arrays
{
    public static class Largest_Number_in_Array
    {
        public static int Execute(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                max = arr[i] > max ? arr[i] : max; 
            }
            return max;
        }

        public static int Execute(List<int> arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Count ; i++)
            {
                max = arr[i] > max ? arr[i] : max;
            }
            return max;
        }

        public static int Run()
        {
            int[] arr = { 1, 8, 7, 56, 90 };
            List<int> arrList = new List<int>{ 1, 8, 7, 56, 92 };
            return Execute(arrList);
        }
    }


    //Given an array arr[]. The task is to find the largest element and return it.

    //Examples:

    //Input: arr[] = [1, 8, 7, 56, 90]
    //    Output: 90
    //Explanation: The largest element of the given array is 90.
    //Input: arr[] = [5, 5, 5, 5]
    //    Output: 5
    //Explanation: The largest element of the given array is 5.
    //Input: arr[] = [10]
    //    Output: 10
    //Explanation: There is only one element which is the largest.
    //Constraints:
    //1 <= arr.size()<= 106
    //0 <= arr[i] <= 106
}
