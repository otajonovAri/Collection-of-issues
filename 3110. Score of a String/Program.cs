Solution solution = new Solution();

System.Console.WriteLine(solution.ScoreOfString("hello"));


public class Solution {
    public int ScoreOfString(string s) 
    {
        int x = 0;

        for(int i = 0; i < s.Length - 1; i++)
        {
            int a = s[i];
            int b = s[i + 1];

            x += Math.Abs(a - b);
        }   

        return x; 
    }
}