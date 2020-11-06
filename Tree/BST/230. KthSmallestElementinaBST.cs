using System.Collections.Generic;
namespace LeetCodeExercises{
    public class KthSmallestElementinaBST{
        private Stack<TreeNode> stack = new Stack<TreeNode>();
        public int KthSmallest(TreeNode root, int k) {
            pushStack(root);
            int val = int.MinValue;
            for (int i = 0; i < k; i++)
            {
                val = getNext();
            }
            return val;
        }

        private int getNext(){
            TreeNode node = stack.Pop();
            pushStack(node.right);
            return node.val;
        }

        private void pushStack(TreeNode node){
            while(node != null){
                stack.Push(node);
                node = node.left;
            }
        }
    }
};