public class Solution {
    public int FirstCompleteIndex(int[] arr, int[][] mat) {
        int rowCount = mat.Length;
        int colCount = mat[0].Length;

        Dictionary<int, int[]> valueToIndexMap = new Dictionary<int, int[]>();
        for (int row = 0; row < rowCount; ++row) {
            for (int col = 0; col < colCount; ++col) {
                valueToIndexMap[mat[row][col]] = new int[] { row, col };
            }
        }

        int[] rowCompletion = new int[rowCount];
        int[] colCompletion = new int[colCount];

        for (int k = 0; k < arr.Length; ++k) {
            if (valueToIndexMap.TryGetValue(arr[k], out int[] coordinates)) {
                int rowIndex = coordinates[0];
                int colIndex = coordinates[1];

                rowCompletion[rowIndex]++;
                colCompletion[colIndex]++;

                if (rowCompletion[rowIndex] == colCount || colCompletion[colIndex] == rowCount) {
                    return k;
                }
            }
        }

        return -1;
    }
}