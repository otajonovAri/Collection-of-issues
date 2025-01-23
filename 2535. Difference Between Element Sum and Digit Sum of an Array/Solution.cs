public class Solution {
    public int DifferenceOfSum(int[] nums) 
    {
        int elementNum = 0;
        int digitNum = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            elementNum += nums[i];
            int number = nums[i];

            while(number != 0)
            {
                digitNum += number % 10;
                number = number / 10;
            }
        }

        return elementNum - digitNum;    
    }
}