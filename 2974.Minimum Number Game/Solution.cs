public class Solution
{
    public int[] NumberGame(int[] nums)
    {
        Array.Sort(nums);

        for (int i = 0; i < nums.Length; i += 2)
        {
            int temp = nums[i];
            nums[i] = nums[i + 1];
            nums[i + 1] = temp;
        }

        return nums;
    }
}