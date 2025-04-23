using ParcellPartnersTechnicalTest;

internal class Program
{
    private static void Main(string[] args)
    {
        //convert string args into a ints
        int[] set = args.ToIntArr();

        //find the missing number
        ArrayEvaluator eval = new ArrayEvaluator();
        int missing = eval.FindMissingNumber(set);

        Console.WriteLine(missing);

    }
}