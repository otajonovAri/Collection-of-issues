internal class Program
{
    private static void Main(string[] args)
    {
        Solution solution= new Solution();
        int[] arr = { 1, 2, 3 , 3 , -1 , 3};
        int target  = -1;

        System.Console.WriteLine(solution.ThreeSumClosest(arr, target));
    }
}

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        if(nums.Length < 3)
            return 0;

        Array.Sort(nums);
        int start = 0;
        int left = 1;
        int right = nums.Length - 1;
        int direction = nums[start] + nums[left] + nums[right] > 0 ? 1 : 0;
        int minDistance = int.MaxValue;
        int sum = int.MinValue;

        while (start < nums.Length - 2)
        {
            while (left < right)
            {
                int currSum = nums[start] + nums[left] + nums[right];
                if ( currSum == target )
                    return target;
                
                if (currSum < target)
                    left++;
                else 
                    right--;

                if (Math.Abs(currSum - target) < minDistance)
                {
                    sum = currSum;
                    minDistance = Math.Abs(currSum - target);
                }
            }
            start ++;
            left = start + 1;
            right = nums.Length - 1;
        }
        return sum;
    }
}
