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
            }

            Console.ReadLine();
            
        }
    }
}
