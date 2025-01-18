public class Solution {
public int MinCost(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int cost = 0;

        var directions = new (int, int)[] { (0, 0), (0, 1), (0, -1), (1, 0), (-1, 0) };
        var queue = new Queue<(int, int)>();
        var visited = new HashSet<(int, int)>();

        bool IsOutOfBoundsOrVisited(int x, int y)
        {
            return x < 0 || x >= m || y < 0 || y >= n || visited.Contains((x, y));
        }

        void DFS(int x, int y)
        {
            while (!IsOutOfBoundsOrVisited(x, y))
            {
                visited.Add((x, y));
                queue.Enqueue((x, y));
                var direction = directions[grid[x][y]]; 
                x += direction.Item1;
                y += direction.Item2;
            }
        }

        DFS(0, 0);

        while (queue.Count > 0)
        {
            if (visited.Contains((m - 1, n - 1))) return cost; 
            cost++;

            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var (x, y) = queue.Dequeue();
                foreach (var (dx, dy) in directions[1..]) 
                {
                    DFS(x + dx, y + dy);
                }
            }
        }

        return -1;
    }
}
