class Backtrack
{
    public static List<List<int>> Permute(List<int> arr)
    {
        var results = new List<List<int>>();

        void Backtrack(List<int> path, List<int> options)
        {
            if (path.Count == arr.Count)
            {
                results.Add(new List<int>(path));
                return;
            }

            for (int i = 0; i < options.Count; i++)
            {
                path.Add(options[i]);
                var remainingOptions = options.Where((_, index) => index != i).ToList();
                Backtrack(path, remainingOptions);
                path.RemoveAt(path.Count - 1);
            }
        }

        Backtrack(new List<int>(), arr);
        return results;
    }
}
