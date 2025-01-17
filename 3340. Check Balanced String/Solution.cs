public class Solution {
    public bool IsBalanced(string num)
    {
        int left = 0, right = 0;
        for (int i = 0; i < num.Length; i++)
        {
            if (i % 2 == 0)
            {
                left += Convert.ToInt32(num[i]) - '0';
            }
            else
            {
                right += Convert.ToInt32(num[i]) - '0';
            }
        }
        return left == right ? true : false;
    }
}