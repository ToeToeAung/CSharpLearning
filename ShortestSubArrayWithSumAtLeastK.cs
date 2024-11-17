public class ShortestSubArrayWithSumAtLeastK{   
    public int ShortestSubarray(int[] nums, int k) {
        int sum=0, st=0, len = nums.Length, minLen = len+2;
        for (int i=st ; i < len ; i++) {            
            if (nums[i]>=0) {
                sum += nums[i]; // Positive Sum
                 Console.WriteLine("1. sum->" +sum);
               }
            else {
                var negSum = 0;
                for (int j=i ; j < len && nums[i]<0 ; j++) {
                    negSum += nums[j];
                    sum += nums[j];
                    nums[j] = 0;
                     Console.WriteLine("negSum->"+ negSum + " sum->" + " nums[j]->"+ nums[j]);
                }
                int l;
                for(l=i-1 ; l>=st && negSum<0 ; l--) {
                    negSum +=nums[l];
                    nums[l]=0;
                }
                if (negSum<0) {
                    sum=0;
                    st=i+1;
                }
				else
                    nums[++l] = negSum; 
            } 
            Console.WriteLine("Sum->" + sum + " st->" +st +  " len-> " +len + " min Len->"+ minLen + " k->"+k);
            
            if (sum >= k) 
                while (st <= i) { 
                    sum -= nums[st++];
                    if (sum < k) {
                        sum += nums[--st];
                        if (minLen > i-st+1)
                            minLen = i-st+1;
                        break;
                    }
                }
        }
        
        return minLen>len ? -1 : minLen;  
    }
}