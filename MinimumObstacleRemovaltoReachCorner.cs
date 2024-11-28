public class MinimumObstacleRemovaltoReachCorner {
    public int MinimumObstacles(int[][] grid) {
                PriorityQueue<(int r, int c), int> agenda = new ();
        
        agenda.Enqueue((0, 0), grid[0][0]);
        
        Dictionary<(int r, int c), int> visited = new() {
            {(0, 0), grid[0][0]},  
        };
        
        while (agenda.Count > 0) {
            var node = agenda.Dequeue();
            
            for (int d = 0; d < 4; ++d) {
                int nr = node.r + (d - 1) % 2;
                int nc = node.c + (d - 2) % 2;
                
                if (nr < 0 || nr >= grid.Length || nc < 0 || nc >= grid[nr].Length)
                    continue;
                
                int cost = visited[(node.r, node.c)] + grid[node.r][node.c];
                
                if (visited.TryGetValue((nr, nc), out int oldCost) && oldCost <= cost)
                    continue;
                
                if (!visited.TryAdd((nr, nc), cost))
                    visited[(nr, nc)] = cost;
                
                agenda.Enqueue((nr, nc), cost);
            }
        }
        
        return visited[(grid.Length - 1, grid[grid.Length - 1].Length - 1)];
    }
}