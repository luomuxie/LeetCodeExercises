using System.Collections.Generic;
using System;
namespace LeetCodeExercises{
    public class BinaryTreeMaximumPathSum{
        int maxValue;
        public int MaxPathSum01(TreeNode root) {
            maxValue = int.MinValue;
            maxPathDown(root);
            return maxValue;
        }

        private int maxPathDown(TreeNode node) {
            if (node == null) return 0;
            int left = Math.Max(0, maxPathDown(node.left));
            int right = Math.Max(0, maxPathDown(node.right));
            maxValue = Math.Max(maxValue, left + right + node.val);
            return Math.Max(left, right) + node.val;
        }
    }

    public class pathSumVo{
        public TreeNode node;
        public int val;
        public TreeNode preNode;
        public pathSumVo(TreeNode node, int val,TreeNode preNode)
        {
            this.node = node;
            this.val = val;
            this.preNode = preNode;
        }
    }

}