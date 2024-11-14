public class MinimizedMaximumClass {
    public int MinimizedMaximum(int n, int[] quantities) {
          int left = 1, right = 100000; 
        while (left < right) {
            int middle = left + (right - left) / 2, storeSum = 0;
    
            foreach (int quantity in quantities) storeSum += (quantity + middle - 1) / middle; 
  
            if (storeSum > n) { 
                left = middle + 1;
            } else { 
                right = middle; 
            }
        }
        
        return left;
    }
}