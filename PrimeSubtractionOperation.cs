 
 public class PrimeSubtractionOperation{
 public bool PrimeSubOperation(int[] nums)
    {
        var prev = 0;
        foreach (var num in nums)
        {
            if (prev >= num)
                return false;

            var index = subtracts.BinarySearch(num - prev);
            index = index < 0 ? ~index : index;
            prev = num - subtracts[index - 1];
        }

        return true;
    }

    private static List<int> subtracts =
        new(Enumerable.Range(1, 1000).Where(IsPrime).Prepend(0));

    private static bool IsPrime(int num)
    {
        if (num <= 1)
            return false;

        for (var i = 2; i <= (int)Math.Sqrt(num); i++)
            if (num % i == 0)
                return false;

        return true;
    }
 }
