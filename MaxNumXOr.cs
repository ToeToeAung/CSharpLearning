public class MaxNumXOr{
       public int[] GetMaximumXor(int[] nums, int maximumBit) {
            var maxNum = (1 << maximumBit) - 1;

            var xorValue = nums.Aggregate((x, y) => x ^ y);
            Console.WriteLine("XorValue " + xorValue);

            var result = new int[nums.Length];
            result[0] = xorValue ^ maxNum;
            Console.WriteLine("Result[0] " +result[0]);
            for (var i = 1; i < nums.Length; i++)
                result[i] = result[i - 1] ^ nums[^i];

            return result;
    }

}