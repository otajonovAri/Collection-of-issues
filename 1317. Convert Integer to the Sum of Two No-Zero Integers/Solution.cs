public class Solution {
    public int[] GetNoZeroIntegers(int n) 
    {
        int[] arr = new int[2];
        for (int i = 1; i < n; i++) {
            if (i.ToString().Contains("0") || (n - i).ToString().Contains("0")) {
                continue;
            } else {
                arr[0] = i;
                arr[1] = n - i;
                break;
            }
        }
        return arr;
    }
}