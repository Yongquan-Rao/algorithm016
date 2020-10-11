public class Solution
{
    public bool CanJump(int[] nums)
    {
        int n = nums.Length;
        int maxPos = nums[0];
        for (int i = 1; i < n; ++i)
        {
            if (maxPos < i) return false;
            maxPos = Math.Max(maxPos, nums[i] + i);
        }
        return true;
    }
}