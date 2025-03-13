Solution obj = new Solution();

System.Console.WriteLine(obj.MinElement([10,12,13,14]));


public class Solution {
    public int MinElement(int[] nums) 
    {
        List<int> list = new List<int>();
        int leng = nums.Length;
        int index = 0;

        while(leng != 0)
        {
            int x = nums[index];
            int sum = 0;

            while(x != 0)
            {
                int endNum = x % 10;
                sum += endNum;
                x /= 10;
            }
            list.Add(sum);
            index++;
            leng--;
        }

        return list.Min();
    }
}