public class Solution
{
    public int Jump(int[] nums)
    {
        int n = nums.Length;
        if (n <= 1) return 0;
        int maxPos = nums[0];
        int maxSteps = nums[0];
        int jumps = 1;
        for (int i = 1; i < n; ++i)
        {
            if (maxSteps < i)
            {
                ++jumps;
                maxSteps = maxPos;
            }
            maxPos = Math.Max(maxPos, nums[i] + i);
        }
        return jumps;
    }
}