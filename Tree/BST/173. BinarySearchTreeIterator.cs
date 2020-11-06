using System.Collections.Generic;
namespace LeetCodeExercises{

    public class BSTIterator {
        private Stack<TreeNode> stack;
        public BSTIterator(TreeNode root) {
            stack = new Stack<TreeNode>();
            pushStack(root);

        }
        
        
        public int Next() {
            TreeNode node = stack.Pop();
            pushStack(node.right);
            return node.val;
        }
                
        public bool HasNext() {
            return stack.Count != 0;
        }

        public void pushStack(TreeNode node) {
            while(node != null){
                stack.Push(node);
                node = node.left;
            }
            
        }        
    }
}