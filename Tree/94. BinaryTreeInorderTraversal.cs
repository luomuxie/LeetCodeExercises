using System.Collections.Generic;
namespace LeetCodeExercises
{
    /*
        需求：返回树的中根遍历
    */
    public class BinaryTreeInorderTraversal
    {

        public IList<int> InorderTraversal01(TreeNode root) {
            IList<int> res = new List<int>();
            if (root == null) return res;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            pushAllLeft(root, stack);
            while (stack.Count != 0) {
                TreeNode cur = stack.Pop();
                res.Add(cur.val);
                pushAllLeft(cur.right, stack);
            }
            return res;
        }

        public void pushAllLeft(TreeNode node, Stack<TreeNode> stack){
            while (node != null) {
                stack.Push(node);
                node = node.left;
            }
        }
    }
}