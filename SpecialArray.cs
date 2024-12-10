public class SpecialArray {
    public bool[] IsArraySpecial(int[] nums, int[][] queries) 
  {
   
    List<int> notSpecial = new List<int>();

    for (int i = 0; i < nums.Length - 1; i++)
        if (nums[i] % 2 + nums[i + 1] % 2 != 1) notSpecial.Add(i);

    bool[] retVal = new bool[queries.Length];
    int index = 0;
    foreach (int[] query in queries)
        retVal[index++] = BinarySearchForSpecial(query[0], query[1], notSpecial);

    return retVal;
}

private bool BinarySearchForSpecial(int from, int to, List<int> notSpecial)
{
    int left = 0;
    int right = notSpecial.Count - 1;

    while (left <= right)
    {
        int mid = (left + right) / 2;
        if (from <= notSpecial[mid] && to > notSpecial[mid]) return false;
        else if (from > notSpecial[mid]) left = mid + 1;
        else right = mid - 1;
    }

    return true;
}
        
}