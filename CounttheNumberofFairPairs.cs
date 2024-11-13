public class CounttheNumberofFairPairs{
     public long CountFairPairs(int[] nums, int lower, int upper) {
        long count = 0;
        Array.Sort(nums);
        int left=nums.Length - 1, right=nums.Length - 1;
        for(int i = 0; i < nums.Length-1; i++) {
            left = Math.Max(left, i+1);
            while(left > i && nums[i] + nums[left] >= lower){
                left--;
            }
            while(right>i && nums[i] + nums[right] > upper){
                right--;
            }
            if (right < left)
                break;
            count += right-left;
        }
        return count;
    }
}