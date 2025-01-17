public class LargestCombinationClass {
    public int LargestCombination(int[] candidates) {
         var data = new Dictionary<int, int>();

        for(int i = 0; i < candidates.Length; ++i)
        {
            var num = candidates[i];

            var power = 2;
            var index = 0;

            while(num > 0)
            {
                if(num % power == 1)
                {
                    data.TryAdd(index, 0);
                    data[index] += 1;

                    num -= 1;
                }

                num /= 2;
                ++index;
            }
        }

        var result = 0;
        foreach(var (key, value) in data)
        {
            result = Math.Max(result, value);
        }  

        return result;
    }
}