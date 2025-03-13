Solution solution = new Solution();

var arr = new int[]{10,10,3,7,6};

int x = solution.CountPartitions(arr);


public class Solution {
    public int CountPartitions(int[] nums)
    {
        var count = 0;
        var left = 0;
        
        for(var i = 0; i < nums.Length; i++)
        {
            var right = 0;            
            left += nums[i];

            for(var j = i + 1; j < nums.Length; j++)
            {
                right += nums[j];
            }
            
             if(Math.Abs(left - right) % 2 == 0 && right != 0)
               count++;
        }

        return count;
    }
}