﻿public class Solution {
    public int UniquePaths(int m, int n) {
        int[] dp = new int[n];
        Array.Fill(dp, 1);
        for (int i = m - 2; i >= 0; -- i) {
            for (int j = n - 2; j >= 0; -- j) {
                dp[j] += dp[j + 1];
            }
        }
        return dp[0];
    }
}