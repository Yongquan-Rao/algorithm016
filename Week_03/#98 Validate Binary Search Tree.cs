/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution
{

    public bool IsValidBST(TreeNode root)
    {
        return Helper(root, null, null);
    }

    private bool Helper(TreeNode root, TreeNode min, TreeNode max)
    {
        if (root == null) return true;

        if (min != null && root.val <= min.val) return false;
        if (max != null && root.val >= max.val) return false;

        return Helper(root.left, min, root) && Helper(root.right, root, max);
    }
}