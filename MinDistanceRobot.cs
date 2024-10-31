public class MinDistanceRobot {
    const int N = (int)1e5 + 1, M = (int)1e6 + 1, INF = (int)1e9;
    int[] pre = new int[M], incf = new int[M], f = new int[M], w = new int[M];
    int[] h = new int[N], ne = new int[M], e = new int[M];
    long[] d = new long[M];
    bool[] st = new bool[M];
    int idx = 0, T = 0, S = 0; 
    public long MinimumTotalDistance(IList<int> robot, int[][] factory) {
        Array.Fill(h, -1);
        int n = robot.Count, m = factory.Length;
        S = n + m + 1; T = n + m + 2;
        long cost = 0;
        for(int i = 0; i < n; i++) Add(S, i, 1, 0);
        for(int i = 0; i < n; i++){
            for(int j = 0; j < m; j++)
                Add(i, j + n, 1, Math.Abs(robot[i] - factory[j][0]));
        }
        for(int i = 0; i < m; i++) Add(i + n, T, factory[i][1], 0);
        EK(ref cost);
        return cost;
    }

    public void EK(ref long cost){
        while (Spfa()) {
            int t = incf[T];
            cost += d[T] * t;
            for (int i = T; i != S; i = e[pre[i] ^ 1]) {
                f[pre[i]] -= t;
                f[pre[i] ^ 1] += t;
            }
        }
    }

    public bool Spfa(){
        Array.Fill(d, (long)1e18);
        Array.Fill(incf, 0);
        Queue<int> q = new();
        q.Enqueue(S); d[S] = 0; incf[S] = INF;
        while (q.Count > 0) {
            int u = q.Dequeue();
            st[u] = false;
            for (int i = h[u]; i != -1; i = ne[i]) {
                int j = e[i];
                if (f[i] > 0 && d[j] > d[u] + w[i]) {
                    d[j] = d[u] + w[i];
                    pre[j] = i;
                    incf[j] = Math.Min(incf[u], f[i]);
                    if (!st[j]) {
                        q.Enqueue(j);
                        st[j] = true;
                    }
                }
            }
        }
        return incf[T] > 0;
    }

    public void Add(int u, int v, int c, int t){
        e[idx] = v; f[idx] = c; w[idx] = t; ne[idx] = h[u]; h[u] = idx++;
        e[idx] = u; f[idx] = 0; w[idx] = -t; ne[idx] = h[v]; h[v] = idx++; 
    }
}