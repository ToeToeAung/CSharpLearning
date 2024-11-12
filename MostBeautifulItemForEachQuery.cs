public class MostBeautifulItemForEachQuery{
    public int[] MaximumBeauty(int[][] items, int[] queries)
    {       
        var comparer = Comparer<int[]>.Create((x, y) =>
            x[0] != y[0] ? y[0] - x[0] : x[1] - y[1]);

        Array.Sort(items, comparer);

        for (var i = items.Length - 1; i > 0; i--)
            if (items[i - 1][1] < items[i][1])
                items[i - 1][1] = items[i][1];

        return Array.ConvertAll(queries, query =>
        {
            var index = items.BinarySearch(item => item[0] <= query);
            return index == items.Length ? 0 : items[index][1];
        });
    }
}

public static class Extensions
{
    public static int BinarySearch<T>(this IList<T> list, Predicate<T> predicate)
    {
        var left = 0;
        var right = list.Count;

        while (left < right)
        {
            var mid = left + (right - left) / 2;

            if (predicate(list[mid]))
                right = mid;
            else
                left = mid + 1;
        }

        return left;
    }
}