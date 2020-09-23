public class Solution
{

    private readonly IList<string> _ans = new List<string>();

    public IList<string> GenerateParenthesis(int n)
    {
        Backtrack("", 0, 0, n);
        return _ans;
    }

    private void Backtrack(string curr, int open, int close, int max)
    {
        if (curr.Length == 2 * max)
        {
            _ans.Add(curr);
            return;
        }

        if (open < max) Backtrack(curr + "(", open + 1, close, max);
        if (close < open) Backtrack(curr + ")", open, close + 1, max);
    }
}