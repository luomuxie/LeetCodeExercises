using System;
namespace LeetCodeExercises{
    public class HouseRobberIII{

        //解法一：该方法效率慢，但好理解
        public int Rob01(TreeNode root) {
            if (root == null) return 0;
            return Math.Max(robInclude(root), robExclude(root));
        }
        
        private int robInclude(TreeNode node) {
            if(node == null) return 0;
            return robExclude(node.left) + robExclude(node.right) + node.val;
        }

        private int robExclude(TreeNode node) {
            if(node == null) return 0;
            return Rob01(node.left) + Rob01(node.right);
        }

        //解法二：
        public int Rob02(TreeNode root) {
            int[] a = money(root);
            return Math.Max(a[0],a[1]);
        }

        private int[] money(TreeNode node) {
            if(node == null) return new int[]{0,0};
            int[] l = money(node.left);
            int[] r = money(node.right);
            int selVal = node.val+l[1]+r[1];
            int unSelVal = Math.Max(l[0],l[1])+Math.Max(r[0],r[1]);            
            return new int[]{selVal,unSelVal};            
        }
    }
}