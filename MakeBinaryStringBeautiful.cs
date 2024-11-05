public class MakeBinaryStringBeautiful{
     public int MinChanges(string s) {
        if (s.Length % 2 != 0) return 0;
        int count = 0;
        for (int i = 0; i < s.Length; i += 2)
        {
            count += helper(s,i, i+1);
        }
        return count;       
    }
    
     private int helper (String s,int left, int right)
        {
            int oneCount = 0;
            if (s[left] == '1') oneCount++;
            if (s[right] == '1') oneCount++;
            return Math.Min(oneCount, 2-oneCount);
        }
}