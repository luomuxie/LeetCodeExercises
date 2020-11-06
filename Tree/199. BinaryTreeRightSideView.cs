using System.Collections.Generic;
using System;
namespace LeetCodeExercises{
    public class BinaryTreeRightSideViewP{
        public IList<int> RightSideView01(TreeNode root) {
            List<int> res = new List<int>();
            if(root == null) return res;
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            while(queue.Count >0){
                int cnt = queue.Count;
                for (int i = 0; i < cnt; i++)
                {
                    TreeNode vo = queue.Dequeue();
                    if(i == 0) res.Add(vo.val);                   
                    if(vo.right != null) queue.Enqueue(vo.right);
                    if(vo.left != null) queue.Enqueue(vo.left);
                }
            }            
            return res;
        }        
    }
}