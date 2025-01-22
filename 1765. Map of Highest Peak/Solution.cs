public class Solution {
    public int[][] HighestPeak(int[][] isWater) {
        int rows = isWater.Length;
        int cols = isWater[0].Length;

        int[][] highestPeaks = new int[rows][];
        for (int i = 0; i < rows; i++) {
            highestPeaks[i] = new int[cols];
        }

        Queue<int[]> queue = new Queue<int[]>();

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                highestPeaks[i][j] = isWater[i][j] - 1;

                if (highestPeaks[i][j] == 0) {
                    queue.Enqueue(new int[] { i, j });
                }
            }
        }

        int[] directions = { -1, 0, 1, 0, -1 };

        while (queue.Count > 0) {
            int[] position = queue.Dequeue();
            int row = position[0];
            int col = position[1];

            for (int k = 0; k < 4; k++) {
                int x = row + directions[k];
                int y = col + directions[k + 1];

                if (x >= 0 && x < rows && y >= 0 && y < cols && highestPeaks[x][y] == -1) {
                    highestPeaks[x][y] = highestPeaks[row][col] + 1;

                    queue.Enqueue(new int[] { x, y });
                }
            }
        }

        return highestPeaks;
    }
}
