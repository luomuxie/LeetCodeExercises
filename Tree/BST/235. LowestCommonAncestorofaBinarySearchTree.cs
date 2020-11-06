namespace LeetCodeExercises{
    public class LowestCommonAncestorofaBinarySearchTree{
        public TreeNode lowestCommonAncestor01(TreeNode root, TreeNode p, TreeNode q) {
            if(root == null) return null; 
            TreeNode minNode = p.val>q.val?q:p;
            TreeNode maxNode = p.val>q.val?p:q;
            return helper(root,minNode,maxNode);                        
        }

        public TreeNode helper(TreeNode root, TreeNode minNode, TreeNode maxNode) {
            if(root == null) return null; 
            if(maxNode.val<root.val)  return helper(root.left,minNode,maxNode);
            if(minNode.val>root.val)  return helper(root.right,minNode,maxNode);                     
            return root;                       
        }
    }
}