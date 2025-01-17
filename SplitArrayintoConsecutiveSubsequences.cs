 public class SplitArrayintoConsecutiveSubsequences{
        public bool IsPossible(int[] nums) {
          if (nums == null || nums.Length < 3)
            {
                return false;
            }

            List<List<int>> lists = new List<List<int>>();
            var l1 = new List<int>();
            l1.Add(nums[0]);
            lists.Add(l1);

            for (int i = 1; i < nums.Length; i++)
            {
                bool added = false;
                var temp = new List<List<int>>();

                foreach (var item in lists)
                {
                    if (item.Last() + 1 == nums[i])
                    {
                        item.Add(nums[i]);
                        added = true;
                        break;
                    }
                    else if(item.Last() + 1 < nums[i])
                    {
                        temp.Add(item);
                    }
                }

                if(temp.Where((x) => x.Count < 3).Count() > 0)
                {
                    return false;
                }

                else
                {
                    foreach (var item in temp)
                    {
                        lists.Remove(item);
                    }
                }
                if (!added)
                {
                    var l = new List<int>();
                    l.Add(nums[i]);
                    lists.Insert(0, l);
                }
            }

            return lists.Where((x) => x.Count < 3).Count() == 0;
    }
 }