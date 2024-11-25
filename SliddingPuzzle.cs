
using System.Text;
public class SlidingPuzzleClass {
    int[][] dirs=new int[][]{new int[]{1,3}, new int[]{0,2,4}, new int[]{1,5},new int[]{0,4},new int[]{3,1,5},new int[]{4,2}};
    public int SlidingPuzzle(int[][] board) {
        string stand="123450";
        var sb=new StringBuilder();
        for(int i=0;i<board.Length;i++)
        {
            for(int j=0;j<board[0].Length;j++)
            {
                sb.Append(board[i][j]);
            }
        }
        var q=new Queue<string>();
        var hs=new HashSet<string>();
        q.Enqueue(sb.ToString());
        hs.Add(sb.ToString());
        int step=0;
        while(q.Any())
        {
            int size=q.Count;
            while(size-->0)
            {
                var cur=q.Dequeue();
                if(cur==stand)return step;
                int id=cur.IndexOf('0');
                foreach(var dir in dirs[id])
                {
                    string newstr=helper(cur,id,dir);
                    if(hs.Contains(newstr))continue;
                    q.Enqueue(newstr);
                    hs.Add(newstr);
                }
            }
            step++;
        }
        return -1;
    }
    string helper(string str,int i,int j)
    {
        var arr=str.ToArray();
        char tmp=arr[i];
        arr[i]=arr[j];
        arr[j]=tmp;
        return new string(arr);
    }
}