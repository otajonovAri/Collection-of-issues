public class Solution {
    public int XorAllNums(int[] nums1, int[] nums2) {
        int xorNums1 = 0, xorNums2 = 0;

        foreach (int num in nums1)
        {
            xorNums1 ^= num;
        }

        foreach (int num in nums2)
        {
            xorNums2 ^= num;
        }

        int result = 0;

        if (nums1.Length % 2 != 0)
        {
            result ^= xorNums2;
        }
        if (nums2.Length % 2 != 0)
        {
            result ^= xorNums1;
        }

        return result;
    }
}