using ParcellPartnersTechnicalTest;

internal class Program
{
    private static void Main(string[] args)
    {
        args = ["9", "6", "4", "2", "3", "5", "7", "0", "1"];
        int[] set = new int[args.Length];

        //convert string args into a ints
        for (int i = 0; i < set.Length; i++) {
            string input = args[i];
            int number = int.Parse(input);
            set[i] = number;
        }

        //find the missing number
        ArrayEvaluator eval = new ArrayEvaluator();
        int missing = eval.FindMissingNumber(set);

        Console.WriteLine(missing);

    }
}