public class ShortestSubarrayToBeRemovedMakeArraySorted{   
    public int FindLengthOfShortestSubarray(int[] arr) {
         if(arr == null || arr.Length == 0)
       {
           return 0;
       }
        
       int n = arr.Length;
       int start = 0;
       int end = n-1;
        
       while(start < n - 1 && arr[start] <= arr[start+1])
           start++;        
   
       if(start == n - 1)
       {           
           return 0;
       }
        
       while(end > 0 && arr[end] >= arr[end - 1])
           end--;
        
       Console.WriteLine(start);
       Console.WriteLine(end);
       int min = end;
       for(int i = 0; i <= start; i++)
       {
           while(end < n && arr[i] > arr[end] )
           {
               end++;
           }
           
           min = Math.Min(min, (end - i - 1));
           
       }
        
       return min; 
    }

}