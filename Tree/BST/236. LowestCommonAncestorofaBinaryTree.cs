namespace LeetCodeExercises{
    public class LowestCommonAncestorofaBinaryTree{
        /*
            找出离两子节点最近的父节点，可包括子点节点
         */
        //解法一：
        TreeNode res = null;
        public TreeNode lowestCommonAncestor01(TreeNode root, TreeNode p, TreeNode q) {
            isFind(root,p,q);
            return res;
        }

        public bool isFind(TreeNode root,TreeNode p,TreeNode q){
            if(root == null) return false;
            int l = isFind(root.left,p,q)?1:0;
            int r = isFind(root.right,p,q)?1:0;
            int mid = 0;
            if(root.val == p.val || root.val == q.val) mid = 1;
            if(l+r+mid >=2) res = root;
            return l+r+mid >0;                                        
        }


    }
}