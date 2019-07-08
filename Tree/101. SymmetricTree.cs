using System.Collections.Generic;
namespace LeetCodeExercises
{
    /*
    需求：判断是否为对称树，其实解法方法对100差不多
     */
    public class SymmetricTree
    {

        //递归解法：
        public bool IsSymmetric(TreeNode root) {
            return root==null || isSymmetricHelp(root.left, root.right);
        }

        private bool isSymmetricHelp(TreeNode left, TreeNode right){
            if(left==null || right==null)
                return left==right;
            if(left.val!=right.val)
                return false;
            return isSymmetricHelp(left.left, right.right) && isSymmetricHelp(left.right, right.left);
        }


        //迭代解法：
        public bool isSymmetric(TreeNode root) {
            if (root == null) return true;
            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root.left);
            stack.Push(root.right);
            while (stack.Count != 0) {
                TreeNode n1 = stack.Pop(), n2 = stack.Pop();
                if (n1 == null && n2 == null) continue;
                if (n1 == null || n2 == null || n1.val != n2.val) return false;
                stack.Push(n1.left);
                stack.Push(n2.right);
                stack.Push(n1.right);
                stack.Push(n2.left);
            }
            return true;
        }
    }
}