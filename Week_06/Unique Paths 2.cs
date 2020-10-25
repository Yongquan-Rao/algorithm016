public class Solution {
    public int UniquePathsWithObstacles(int[][] obstacleGrid) {
        var dp = obstacleGrid;
        
        int m = dp.Length;
        if (m == 0) return 0;
        int n = dp[0].Length;
        
        dp[0][0] = 1 - dp[0][0];
        for (int i = 1; i < m; ++ i) {
            dp[i][0] = dp[i - 1][0] * (1 - dp[i][0]);
        }
        for (int i = 1; i < n; ++ i) {
            dp[0][i] = dp[0][i - 1] * (1 - dp[0][i]);
        }
        
        for (int i = 1; i < m; ++ i) {
            for (int j = 1; j < n; ++ j) {
                dp[i][j] = (dp[i - 1][j] + dp[i][j - 1]) * (1 - dp[i][j]);
            }
        }
        
        return dp[m - 1][n - 1];
    }
}