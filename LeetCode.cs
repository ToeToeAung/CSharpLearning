public class LeetCode{
 public int MaxMoves(int[][] grid) {
        int totalRow = grid.Length, totalColumn = grid[0].Length;
        int[,] DP = new int[totalRow, totalColumn];

        for (int col = totalColumn - 2; col >= 0; col--)
        {
            for (int row = 0; row < totalRow; row++)
            {
                int actualValue = grid[row][col];

                if (row > 0 && grid[row-1][col+1] > actualValue)
                    DP[row, col] = Math.Max(DP[row, col], 1 + DP[row-1, col+1]);

                if (grid[row][col+1] > actualValue)
                    DP[row, col] = Math.Max(DP[row, col], 1 + DP[row, col+1]);

                if (row + 1 < totalRow && grid[row+1][col+1] > actualValue)
                    DP[row, col] = Math.Max(DP[row, col], 1 + DP[row+1, col+1]);
            }
        }

        int maxMoves = 0;
        for (int row = 0; row < totalRow; row++)
        {
            maxMoves = Math.Max(maxMoves, DP[row, 0]);
        }

        return maxMoves;
    }
}

