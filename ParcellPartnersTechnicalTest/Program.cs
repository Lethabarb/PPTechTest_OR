using ParcellPartnersTechnicalTest.Services;
using ParcellPartnersTechnicalTest.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        args = ["0", "2", "3", "4", "5","6", "7", "8", "9"];
        //convert string args into a ints
        int[] set = args.ToIntArr();

        //find the missing number
        int missing = ArrayEvaluator.FindMissingNumber(set);

        Console.WriteLine(missing);

    }
}