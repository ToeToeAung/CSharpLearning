public class MaxNumXOr{    public char[][] RotateTheBox(char[][] box) {
          if(box == null || box[0].Length == 0)
            return new char[0][];
        
        int m = box.Length, n = box[0].Length;
        for(int i = 0; i < m; i++)
        {
            int empty = n - 1;           
            for(int j = n - 1; j >= 0; j--)
            {
                if(box[i][j] == '*')
                    empty = j - 1;
                else if(box[i][j] == '#')
                {
                    box[i][j] = '.';
                    box[i][empty] = '#';           
                    empty--;
                }
            }
        }
        
        char[][] res = new char[n][];
        for(int i = 0; i < n; i++)
            res[i] = new char[m];
        
        for(int i = 0; i < m; i++)
        {
            for(int j = 0; j < n; j++)
            {
                res[j][m-1-i] = box[i][j];
            }
        }
        
        return res;
    }

}