public class Solution {
    public int MostWordsFound(string[] sentences) {
        int count = 0;
        for(int i = 0; i < sentences; i++)
        {
            string[] s = sentences[i].Split(" ");
            if(s.Length > count)
            {
                count = s.Length;
            }
        }
    }
}