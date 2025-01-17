public class Solution {
    public bool DoesValidArrayExist(int[] derived) {
        int xorSum = 0;
        
        foreach (var num in derived) {
            xorSum ^= num;
        }

        return xorSum == 0;
    }
}