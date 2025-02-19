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
            }

            Console.ReadLine();
            
        }
    }
}
