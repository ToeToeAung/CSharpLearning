public class ShortestDistanceAfterRoadAdditionQueriesI{
    public int[] ShortestDistanceAfterQueries(int n, int[][] queries) {
          List<int>[] Paths = new List<int>[n];
        int[] shortestDistance = new int[n];
        for (int i = 0; i < n; ++i) {
            Paths[i] = new List<int>();
            if (i + 1 < n) {
                Paths[i].Add(i + 1);
            }
            shortestDistance[i] = i;
        }
        int[] answer = new int[queries.Length];
        for (int q = 0; q < queries.Length; ++q) {
            Paths[queries[q][0]].Add(queries[q][1]);
            for (int j = queries[q][0]; j < n; ++j) {
                foreach (int next in Paths[j]) {
                    shortestDistance[next] = Math.Min(shortestDistance[next], shortestDistance[j] + 1);
                }
            }
            answer[q] = shortestDistance[n - 1];
        }
        return answer;
    }
}