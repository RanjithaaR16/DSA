using DSA_Projects.Problems.Arrays;
using System.Transactions;

namespace DSA_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the selection to proceed");
            Console.WriteLine("1. Largest number in Array");
            Console.WriteLine("2. Sum of square numbers");
            Console.WriteLine("3. FindDisappearedNumbers");
            Console.WriteLine("4. Intersection of two arrays");
            Console.WriteLine("5. Difference of two arrays");
            Console.WriteLine("6. Find duplicates in arrays");
            Console.WriteLine("7. Find median in arrays");
            Console.WriteLine("8. Container with most water");
            Console.WriteLine("9. Trapping Water problem");
            int selection = Convert.ToInt16(Console.ReadLine());
            switch(selection)
            {
                case 1:
                    int max = Largest_Number_in_Array.Run();
                    Console.WriteLine("Max number: " + max);
                    break;
                case 2:
                    bool isSquarePossible = Sum_of_Square_numbers.Run();
                    Console.WriteLine("Is Square possible: " + isSquarePossible);
                    break;
                case 3:
                    IList<int> result = FindDisappearedNumbers.Run();
                    Console.WriteLine("Disappeared numbers: " + result);
                    break;
                case 4:
                    int[] intersection = IntersectionOfTwoArrays.Run();
                    Console.WriteLine("Intersection of arrays: " + intersection);
                    break;
                case 5:
                    IList<IList<int>> difference = DifferenceOfTwoArrays.Run();
                    Console.WriteLine("Difference of arrays: " + difference);
                    break;
                case 6:
                    IList<int> duplicates = FindDuplicatesinArray.Run();
                    Console.WriteLine("Duplicates in arrays: " + duplicates);
                    break;
                case 7:
                    double median = FindMedianOfArray.Run();
                    Console.WriteLine("Median in arrays: " + median);
                    break;
                case  8:
                    int maxWater = ContainerWithMostWater.Run();
                    Console.WriteLine("Container With most water: " + maxWater);
                    break;
                case 9:
                    int trappingWater = TrappingRainWater.Run();
                    Console.WriteLine("Trapping rain water: " + trappingWater);
                    break;
            }

            Console.ReadLine();
            
        }
    }
}
