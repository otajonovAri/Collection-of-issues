public class Solution {
    public long GridGame(int[][] grid) {
        long n=grid[0].Length;

        long[] row1=new long[n];
        long[] row2=new long[n];

        grid[0].CopyTo(row1, 0);
        grid[1].CopyTo(row2, 0);

        for(int i=1; i<n; i++){
            row1[i]+=row1[i-1];
            row2[i]+=row2[i-1];
        }

        long res = Int64.MaxValue;

        for(int i=0; i<n; i++){
            long top=row1[n-1]-row1[i];
            long bottom= i>0 ? row2[i-1] :0;
            long second=Math.Max(top, bottom);
            res=Math.Min(res, second);
        }

        return res;
    }
}