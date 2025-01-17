public class MinimumMountainRemoval{
    public int MinimumMountainRemovals(int[] nums) {
        int[] lis1 = new int[nums.Length];
        int[] lis2 = new int[nums.Length];
        
        for (int i = 0; i < nums.Length; i++)
        {
            lis1[i] = 1;
            lis2[nums.Length - i - 1] = 1;
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j])
                    lis1[i] = Math.Max(lis1[i], lis1[j] + 1);

                if (nums[nums.Length - i - 1] > nums[nums.Length - j - 1])
                    lis2[nums.Length - i - 1] = Math.Max(lis2[nums.Length - i - 1], lis2[nums.Length - j - 1] + 1);
            }
        }

        int maxLength = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (lis1[i] > 1 && lis2[i] > 1)
                maxLength = Math.Max(maxLength, lis1[i] + lis2[i] - 1);
        }

        return nums.Length - maxLength;
    }
}