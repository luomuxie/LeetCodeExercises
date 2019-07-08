/* 
* @Author: XIEXIAN  
* @Date: 2019-07-05 14:46:28  
 * @Last Modified by: XIEXIAN
 * @Last Modified time: 2019-07-05 16:00:22
*/
using System.Collections.Generic;
namespace LeetCodeExercises
{
    public class InvertBinaryTree
    {
        /*
        需求，左右翻转树
        */

        //解法一：递归
        public TreeNode InvertTree01(TreeNode root) {
            if (root == null) {
                return null;
            }
            TreeNode right = InvertTree01(root.right);
            TreeNode left = InvertTree01(root.left);
            root.left = right;
            root.right = left;
            return root ;
        }

        //解法二：迭代
        public TreeNode InvertTree02(TreeNode root) {
            if(root == null) return null;
            Stack<TreeNode> stack = new Stack<TreeNode>();            
            stack.Push(root);
            while(stack.Count != 0)
            {
                TreeNode node = stack.Pop();
                TreeNode left = node.left;
                node.left = node.right;
                node.right = left;
                if(node.left != null) stack.Push(node.left);
                if(node.right != null) stack.Push(node.right);
            }
            return root;            
        }

        //解法二：迭代
        public TreeNode InvertTree03(TreeNode root) {
            if(root == null) return null;
            Queue<TreeNode> stack = new Queue<TreeNode>();            
            stack.Enqueue(root);
            while(stack.Count != 0)
            {
                TreeNode node = stack.Dequeue();
                TreeNode left = node.left;
                node.left = node.right;
                node.right = left;
                if(node.left != null) stack.Enqueue(node.left);
                if(node.right != null) stack.Enqueue(node.right);
            }
            return root;            
        }   
    }
}
