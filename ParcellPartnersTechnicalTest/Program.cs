using ParcellPartnersTechnicalTest.Services;
using ParcellPartnersTechnicalTest.Utilities;

internal class Program
{
    private static void Main(string[] args)
    {
        args = ["hello"];
        //convert string args into a ints
        int[] set = args.ToIntArr();

        //find the missing number
        ArrayEvaluator eval = new ArrayEvaluator();
        int missing = eval.FindMissingNumber(set);

        Console.WriteLine(missing);

    }
}