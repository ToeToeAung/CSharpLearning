
public class SplitarrayLargestSum {
    public int SplitArray(int[] nums, int k) {
        int sum = 0;
        int max = 0;
        foreach(var num in nums)
        {
            max = Math.Max(max, num);
            sum += num;
        }
        
        int left = max;
        int right = sum;
        
        while(left < right)
        {
            int mid = left + (right - left)/2;
            if(isValid(nums, mid, k))
            {
                right = mid;
            }
            else
            {
                left = mid + 1;
            }            
        }
        return left;   
    }
     
    
    private bool isValid(int[] nums, int target, int k)
    {
        int total = 0;
        int count = 1;        
        foreach(var num in nums)
        {
            total += num;
            if(total > target)
            {
                total = num;
                count++;
            } 
            if(count > k)
                return false;
        }
        return true;        
    }
}